using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static Банк.MainDisplay;

namespace Банк
{
    public partial class openingDeposit : Form
    {
        public openingDeposit()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(Global.database);
        string signCurrency;

        private void openingDeposit_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            label7.Visible = false;

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "select name_currency, deposit_percentange, name_interest, iif(prolongation = 1, 'Да', 'Нет') as prolongation, name_deposit_default from deposits, interestPaymentsDep, currencies where deposits.interest_dep = interestPaymentsDep.id_interest_dep and currencies.currency_code = deposits.currency_code and id_deposit = @id_dep;";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@id_dep", Global.openDeposit);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string currency = reader.GetString(0);
                                string percentage = reader.GetDouble(1).ToString() + "%";
                                string name_interest = reader.GetString(2);
                                string prolongation = reader.GetString(3);
                                string name = reader.GetString(4);

                                lblName.Text = "Открыть " + name;
                                lblPercentage.Text = percentage;
                                lblInterest.Text = name_interest;
                                lblProlongation.Text = prolongation;

                                if (currency == "CNY")
                                {
                                    signCurrency = "¥";
                                }
                                else if (currency == "RUB")
                                {
                                    signCurrency = "₽";
                                }
                                else if (currency == "AED")
                                {
                                    signCurrency = "dh";
                                }
                                else if (currency == "USD")
                                {
                                    signCurrency = "$";
                                }
                                else if (currency == "EUR")
                                {
                                    signCurrency = "€";
                                }
                                lblSum.Text = Global.openDepositSum.ToString("N")+ " " + signCurrency;
                                lblPeriod.Text = Global.openDepositPeriod.ToString() + " мес.";
                            }
                            reader.Close();
                        }
                    }

                    string checkCustomerPassport = "select count(passport_customer) from customersDeposits, customers, deposits where customersDeposits.customer_id = customers.id_customer and deposits.id_deposit = customersDeposits.deposit_id and passport_customer = @passport_customer and contribution = 1;";

                    using (SqlCommand checkCust = new SqlCommand(checkCustomerPassport, connect))
                    {
                        checkCust.Parameters.AddWithValue("@passport_customer", Number.passport_customer);
                        int count = (int)checkCust.ExecuteScalar();

                        if (count == 0)
                        {
                            label7.Visible = true;
                        }
                        else
                        {
                            dataGridView1.Visible = true;

                            selectData = "select id_customer_deposit, name_deposit as Название, bank_account as 'Номер счета', deposit_date as 'Дата открытия', return_deposit_date as 'Дата окончания', deposit_amount as 'Сумма', status_dep as 'Статус' from deposits, customersDeposits, customers where contribution = 1 and deposits.id_deposit = customersDeposits.deposit_id and status_dep = 'Действующий' and customers.id_customer = customersDeposits.customer_id and passport_customer =  @passport";

                            using (SqlCommand cmd = new SqlCommand(selectData, connect))
                            {
                                cmd.Parameters.AddWithValue("@passport", Number.passport_customer);

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
            LoadForm(new openCurrentDeposit());
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

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Width > 680 && dataGridView1.DataSource != null)
            {
                dataGridView1.Columns[3].Visible = true;
                dataGridView1.Columns[4].Visible = true;
                dataGridView1.Columns[6].Visible = true;
            }
            if (dataGridView1.Width <= 680 && dataGridView1.DataSource != null)
            {
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[6].Visible = false;
            }
        }

        private void btnTranfer_Click(object sender, EventArgs e)
        {
            if (Global.openDepositSum > double.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString()))
            {
                MessageBox.Show("Недостаточно средств", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /*Random random = new Random();
                Global.code = random.Next(1000, 9999).ToString();*/
                Global.code = "1";
                Global.accountFrom = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                try
                {
                    /*WebClient client = new WebClient();
                    Stream stream = client.OpenRead(string.Format("https://platform.clickatell.com/messages/http/send?apiKey=rM-C7AU_SRS-VEpht3wYKw==&to=79111355208&content={1}", Global.code));
                    StreamReader reader = new StreamReader(stream);*/
                    MessageBox.Show("Код подтверждения успешно отправлен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    acceptOpenDeposit acceptOpenDeposit = new acceptOpenDeposit();
                    acceptOpenDeposit.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
