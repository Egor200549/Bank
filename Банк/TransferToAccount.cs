using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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

        private void TransferToAccount_Load(object sender, EventArgs e)
        {
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
                                }
                                else if (currency == "RUB")
                                {
                                    lblSum.Text += " ₽";
                                }
                                else if (currency == "AED")
                                {
                                    lblSum.Text += " dh";
                                }
                                else if (currency == "USD")
                                {
                                    lblSum.Text += " $";
                                }
                                else if (currency == "EUR")
                                {
                                    lblSum.Text += " €";
                                }
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
            Label label = (Label)sender;
            label.ForeColor = Color.Silver;
            Cursor = Cursors.Hand;
        }

        private void lblGoBack_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.White;
            Cursor = Cursors.Default;
        }
    }
}
