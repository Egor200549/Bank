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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
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
        double sum;
        string min_sum;

        private void TransferToAccount_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            label1.Visible = false;
            btnTranfer.Enabled = false;

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
                                sum = reader.GetSqlMoney(1).ToDouble();

                                try
                                {
                                    min_sum = reader.GetSqlMoney(2).ToDouble().ToString("N");
                                }
                                catch
                                {
                                    min_sum = "отсутствует";
                                }

                                string currency = reader.GetString(3);
                                string current_percentage = reader.GetDouble(4).ToString() + "%";
                                string contract_number = reader.GetString(5);

                                lblNameAccountFrom.Text = name;
                                lblPercentage.Text = current_percentage;
                                lblSum.Text = sum.ToString("N");
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

                            selectData = "select id_customer_deposit, name_deposit as Название, bank_account as 'Номер счета', deposit_date as 'Дата открытия', return_deposit_date as 'Дата окончания', deposit_amount as 'Сумма', status_dep as 'Статус' from deposits, customersDeposits, customers where contribution = 1 and deposits.id_deposit = customersDeposits.deposit_id and status_dep = 'Действующий' and id_customer_deposit != @dep and customers.id_customer = customersDeposits.customer_id and passport_customer =  @passport";

                            using (SqlCommand cmd = new SqlCommand(selectData, connect))
                            {
                                cmd.Parameters.AddWithValue("@passport", Number.passport_customer);
                                cmd.Parameters.AddWithValue("@dep", Global.deposit);

                                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                                DataTable table = new DataTable();
                                adapter.Fill(table);

                                dataGridView1.DataSource = table;
                                dataGridView1.Columns[0].Visible = false;
                                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[3].Visible = false;
                                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[4].Visible = false;
                                dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[6].Visible = false;
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

        private void txtSumToTransfer_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtSumToTransfer.Text, @"^[0-9]{1,8}\,[0-9]{2}$") == false)
            {
                txtSumToTransfer.ForeColor = Color.Red;
                btnTranfer.Enabled = false;
            }
            else
            {
                txtSumToTransfer.ForeColor = Color.Black;
                btnTranfer.Enabled = true;
            }
        }

        private void btnTranfer_Click(object sender, EventArgs e)
        {
            double.TryParse(txtSumToTransfer.Text, out double sum_to_transfer);

            if (sum_to_transfer > sum)
            {
                MessageBox.Show("Недостаточно средств", "Перевод недоступен", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        using (SqlCommand command = new SqlCommand("transfer_", connect))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            SqlParameter id_from = new SqlParameter
                            {
                                ParameterName = "@from",
                                Value = Global.deposit
                            };

                            command.Parameters.Add(id_from);

                            SqlParameter id_to = new SqlParameter
                            {
                                ParameterName = "@to",
                                Value = dataGridView1.SelectedRows[0].Cells[0].Value
                            };

                            command.Parameters.Add(id_to);

                            SqlParameter amount_of_money = new SqlParameter
                            {
                                ParameterName = "@sum",
                                Value = sum_to_transfer
                            };

                            command.Parameters.Add(amount_of_money);
                            command.ExecuteScalar();

                            MessageBox.Show("Перевод успешно осуществлен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadForm(new Deposit());
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
        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Width > 705 && dataGridView1.DataSource != null)
            {
                dataGridView1.Columns[3].Visible = true;
                dataGridView1.Columns[4].Visible = true;
                dataGridView1.Columns[6].Visible = true;
            }
            if (dataGridView1.Width <= 705 && dataGridView1.DataSource != null)
            {
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[6].Visible = false;
            }
        }
    }
}
