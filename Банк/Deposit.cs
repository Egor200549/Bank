using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Банк.MainDisplay;

namespace Банк
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(Global.database);

        private void Deposit_Load(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "select name_deposit, contract_number_dep, deposit_percentange, period_dep, deposit_date, return_deposit_date, deposit_amount, return_deposit_amount, earnings, name_currency, last_name_emp, first_name_customer from customersDeposits, customers, deposits, bankStaff, currencies where customers.id_customer = customersDeposits.customer_id and deposits.id_deposit = customersDeposits.deposit_id and customersDeposits.emp_id = bankStaff.id_emp and currencies.currency_code = deposits.currency_code and id_customer_deposit = @id_dep;";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@id_dep", Global.deposit);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string name = reader.GetString(0);
                                string contract = reader.GetInt32(1).ToString();
                                string percentage = reader.GetDouble(2).ToString();
                                string period = reader.GetInt32(3).ToString();
                                string date = reader.GetDateTime(4).ToString("yyyy-MM-dd");
                                string returnDate = reader.GetDateTime(5).ToString("yyyy-MM-dd");
                                string sum = reader.GetSqlMoney(6).ToString();
                                string returnSum = reader.GetSqlMoney(7).ToString();
                                string income = reader.GetSqlMoney(8).ToString();
                                string currency = reader.GetString(9);
                                string nameEmp = reader.GetString(11) + " " + reader.GetString(10);

                                /*label1.Text = name;
                                label2.Text = contract;
                                label3.Text = percentage;
                                label4.Text = period;
                                label5.Text = date;
                                label6.Text = returnDate;
                                label7.Text = sum;
                                label8.Text = returnSum;
                                label9.Text = income;
                                label10.Text = currency;
                                label11.Text = nameEmp;*/

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
