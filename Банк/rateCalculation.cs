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
    public partial class rateCalculation : Form
    {
        public rateCalculation()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(Global.database);

        private void rateCalculation_Load(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "select min_balance, deposit_percentange, dif_percentage, max_sum, min_sum, name_currency from customersDeposits, deposits, currencies where deposits.id_deposit = customersDeposits.deposit_id and id_customer_deposit = @id_dep and currencies.currency_code = deposits.currency_code;";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@id_dep", Global.deposit);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                double min_balance = reader.GetSqlMoney(0).ToDouble();
                                double percentage = reader.GetDouble(1);
                                double dif_percentage = reader.GetDouble(2);
                                double max = reader.GetSqlMoney(3).ToDouble();
                                double min_sum = reader.GetSqlMoney(4).ToDouble();
                                string currency = reader.GetString(5);

                                label1.Text = "От " + min_sum.ToString() + " до " + max.ToString();
                                label2.Text = "От " + max.ToString();
                                lblMinSum.Text = min_balance.ToString();
                                lblPercentage.Text = percentage.ToString() + "%";
                                lblDifPercentage.Text = dif_percentage.ToString() + "%";

                                if (currency == "CNY")
                                {
                                    label1.Text += " ¥";
                                    label2.Text += " ¥";
                                    lblMinSum.Text += " ¥";
                                }
                                else if (currency == "RUB")
                                {
                                    label1.Text += " ₽";
                                    label2.Text += " ₽";
                                    lblMinSum.Text += " ₽";
                                }
                                else if (currency == "AED")
                                {
                                    label1.Text += " dh";
                                    label2.Text += " dh";
                                    lblMinSum.Text += " dh";
                                }
                                else if (currency == "USD")
                                {
                                    label1.Text += " $";
                                    label2.Text += " $";
                                    lblMinSum.Text += " $";
                                }
                                else if (currency == "EUR")
                                {
                                    label1.Text += " €";
                                    label2.Text += " €";
                                    lblMinSum.Text += " €";
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
