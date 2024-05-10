using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Банк.MainDisplay;

namespace Банк
{
    public partial class TransferToAccount : Form
    {
        public TransferToAccount()
        {
            InitializeComponent();
        }

        private void LoadForm(object Form)
        {
            if (Global.pnDeposit.Controls.Count > 0)
                Global.pnDeposit.Controls.RemoveAt(0);
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            Global.pnDeposit.Controls.Add(form);
            Global.pnDeposit.Tag = form;
            form.Show();
        }

        SqlConnection connect = new SqlConnection(Global.database);

        string signCurrency = "";

        private void TransferToAccount_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            label1.Visible = false;

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "select name_deposit, deposit_amount, min_sum, name_currency, current_percentage, bank_account from customersDeposits, deposits, currencies where customersDeposits.deposit_id = deposits.id_deposit and currencies.currency_code = deposits.currency_code and id_customer_deposit = @id_dep;";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@id_dep", Global.deposit);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string name = reader.GetString(0);
                                string sum = reader.GetSqlMoney(1).ToDouble().ToString("N");
                                string min_sum;

                                try
                                {
                                    min_sum = reader.GetSqlMoney(2).ToDouble().ToString("N");
                                }
                                catch
                                {
                                    min_sum = "";
                                }

                                string currency = reader.GetString(3);
                                string current_percentage = reader.GetDouble(4).ToString() + "%";
                                string contract_number = reader.GetString(5);

                                lblNameAccountFrom.Text = name;
                                lblPercentage.Text = current_percentage;
                                lblSum.Text = sum;
                                lblNum.Text = "••" + contract_number.Substring(16, 4) + " • Неснижаемый остаток " + min_sum;

                                if (currency == "CNY")
                                {
                                    lblSum.Text += " ¥";
                                    signCurrency = "¥";
                                }
                                else if (currency == "RUB")
                                {
                                    lblSum.Text += " ₽";
                                    signCurrency = "₽";
                                }
                                else if (currency == "AED")
                                {
                                    lblSum.Text += " dh";
                                    signCurrency = "dh";
                                }
                                else if (currency == "USD")
                                {
                                    lblSum.Text += " $";
                                    signCurrency = "$";
                                }
                                else if (currency == "EUR")
                                {
                                    lblSum.Text += " €";
                                    signCurrency = "€";
                                }
                            }
                            reader.Close();
                        }
                    }

                    string checkCustomerPassport = "select count(passport_customer) from customersDeposits, customers, deposits where customersDeposits.customer_id = customers.id_customer and deposits.id_deposit = customersDeposits.deposit_id and passport_customer = @passport_customer and id_customer_deposit != @dep and contribution = 1;";

                    using (SqlCommand checkCust = new SqlCommand(checkCustomerPassport, connect))
                    {
                        checkCust.Parameters.AddWithValue("@passport_customer", Number.passport_customer);
                        checkCust.Parameters.AddWithValue("@dep", Global.deposit);
                        int count = (int)checkCust.ExecuteScalar();

                        if (count == 0)
                        {
                            label1.Visible = true;
                            txtSumToTransfer.Enabled = false;
                        }
                        else
                        {
                            dataGridView1.Visible = true;

                            selectData = "select id_customer_deposit, name_deposit as Название, period_dep as 'Период (мес)', deposit_date as 'Дата открытия', return_deposit_date as 'Дата окончания', deposit_amount as 'Сумма', status_dep as 'Статус' from deposits, customersDeposits, customers where contribution = 1 and deposits.id_deposit = customersDeposits.deposit_id and status_dep = 'Действующий' and id_customer_deposit != @dep and customers.id_customer = customersDeposits.customer_id and passport_customer =  @passport";

                            using (SqlCommand cmd = new SqlCommand(selectData, connect))
                            {
                                cmd.Parameters.AddWithValue("@passport", Number.passport_customer);
                                cmd.Parameters.AddWithValue("@dep", Global.deposit);

                                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                                DataTable table = new DataTable();
                                adapter.Fill(table);

                                dataGridView1.DataSource = table;
                                dataGridView1.Columns[0].Visible = false;
                                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[5].ValueType = typeof(SqlMoney);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void lblGoBack_Click(object sender, EventArgs e)
        {
            LoadForm(new Deposit());
        }

        private void lblGoBack_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            label.ForeColor = Color.Silver;
            Cursor = Cursors.Hand;
        }

        private void lblGoBack_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            label.ForeColor = Color.White;
            Cursor = Cursors.Default;
        }

        string inputed = "";

        private void txtSumToTransfer_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSumToTransfer.Text.Length <= 1)
            {
                txtSumToTransfer.Text = txtSumToTransfer.Text + " " + signCurrency;
            }
            else
            {
                inputed = txtSumToTransfer.Text.Substring(0, txtSumToTransfer.Text.Length - 2);
                txtSumToTransfer.Text = inputed + " " + signCurrency;
            }
        }
    }
}
