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

                    string selectData = "select name_deposit, contract_number_dep, bank_account, deposit_date, period_dep, return_deposit_date, deposit_percentange, deposit_amount, return_deposit_amount, min_balance, min_sum, max_sum, name_currency, iif(contribution = 1, 'Разрешено', 'Не разрешено'), iif(write_off = 1, 'Разрешено', 'Не разрешено'), name_interest, early_percentage, dif_percentage, iif(prolongation = 1, 'Да', 'Нет'), place, concat(last_name_emp, ' ', first_name_emp), status_dep from customersDeposits, deposits, currencies, interestPaymentsDep, bankStaff where customersDeposits.id_customer_deposit = deposits.id_deposit and currencies.currency_code = deposits.currency_code and interestPaymentsDep.id_interest_dep = deposits.interest_dep and customersDeposits.emp_id = bankStaff.id_emp and id_customer_deposit = @id_dep;";

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
                                string bankAccount = reader.GetString(2);
                                string date = reader.GetDateTime(3).ToString("yyyy-MM-dd");
                                string period = reader.GetInt32(4).ToString();
                                string returnDate = reader.GetDateTime(5).ToString("yyyy-MM-dd");
                                string percentage = reader.GetDouble(6).ToString();
                                string sum = reader.GetSqlMoney(7).ToString();
                                string returnSum = reader.GetSqlMoney(8).ToString();
                                string min_balance = reader.GetSqlMoney(9).ToString();
                                string min_sum = reader.GetSqlMoney(10).ToString();
                                string max_sum = reader.GetSqlMoney(11).ToString();
                                string currency = reader.GetString(12);
                                string contribution = reader.GetString(13);
                                string write_off = reader.GetString(14);
                                string name_interest = reader.GetString(15);
                                string early_percentage = reader.GetDouble(16).ToString();
                                string dif_percentage = reader.GetDouble(17).ToString();
                                string prolongation = reader.GetString(18);
                                string nameEmp = reader.GetString(19);
                                string status_dep = reader.GetString(20);

                                lblName.Text = name;
                                lblAccount.Text = bankAccount;
                                lblInterest.Text = name_interest;
                                lblPercenrage.Text = percentage;
                                lblCurrency.Text += currency;
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
