using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Банк.MainDisplay;

namespace Банк
{
    public partial class info_bank_account : Form
    {
        public info_bank_account()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(Global.database);

        private void info_bank_account_Load(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "select name_deposit, name_currency, deposit_amount, deposit_percentange, min_sum, contribution, write_off, dif_percentage, status_dep, deposit_date, period_dep, return_deposit_date, max_sum from customersDeposits, deposits, currencies where customersDeposits.deposit_id = deposits.id_deposit and currencies.currency_code = deposits.currency_code  and id_customer_deposit = @id_dep;";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@id_dep", Global.deposit);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string name = reader.GetString(0);
                                string currency = reader.GetString(1);
                                double amount = reader.GetSqlMoney(2).ToDouble();
                                double dep_percentage = reader.GetDouble(3);
                                double min_sum;

                                try
                                {
                                    min_sum = reader.GetSqlMoney(4).ToDouble();
                                }
                                catch
                                {
                                    min_sum = 0;
                                }

                                bool contribution = reader.GetBoolean(5);
                                bool write_off = reader.GetBoolean(6);
                                double dif_percentage = reader.GetDouble(7);
                                string status = reader.GetString(8);
                                DateTime deposit_date = reader.GetDateTime(9);
                                int period;

                                try
                                {
                                    period = reader.GetInt32(10);
                                }
                                catch
                                {
                                    period = 0;
                                }

                                DateTime return_deposit_date;

                                try
                                {
                                    return_deposit_date = reader.GetDateTime(11);
                                }
                                catch
                                {
                                    return_deposit_date = DateTime.Now;
                                }

                                double max_sum;

                                try
                                {
                                    max_sum = reader.GetSqlMoney(12).ToDouble();
                                }
                                catch
                                {
                                    max_sum = 0;
                                }

                                lblName.Text = name;
                                lblCurrency.Text = currency;

                                string signCurrency = "";

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

                                lblAmount.Text = amount.ToString() + " " + signCurrency;

                                if (amount >= min_sum && amount <= max_sum)
                                {
                                    lblPercentage.Text = dep_percentage.ToString() + "%";
                                }
                                else
                                {
                                    lblPercentage.Text = dif_percentage.ToString() + "%";
                                }

                                if (contribution)
                                {
                                    lblContribution.Text = "Разрешено";
                                }
                                else
                                {
                                    lblContribution.Text = "Недоступно";
                                }

                                if (write_off)
                                {
                                    lblWriteOff.Text = "Разрешено";
                                }
                                else
                                {
                                    lblWriteOff.Text = "Недоступно";
                                }

                                lblStatus.Text = status;
                                
                                if (amount - min_sum >= 0)
                                {
                                    lblAvailability.Text = (amount - min_sum).ToString() + " " + signCurrency;
                                }
                                else
                                {
                                    lblAvailability.Text = "0" + " " + signCurrency;
                                }

                                DateTime zero = new DateTime(1, 1, 1);
                                DateTime now = DateTime.Now;
                                TimeSpan some = now - deposit_date;

                                int months = (zero + some).Month;

                                lblNextDate.Text = deposit_date.AddMonths(months).ToString("dd-MM-yyyy");

                                if (dep_percentage == 0)
                                {
                                    panel5.Visible = false;
                                    panel4.Visible = false;
                                    panel8.Visible = false;
                                    panel7.Visible = false;
                                    panel10.Visible = false;
                                    panel11.Visible = false;
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
    }
}
