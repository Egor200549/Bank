using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Банк.MainDisplay;

namespace Банк
{
    public partial class AboutDeposit : Form
    {
        public AboutDeposit()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(Global.database);

        private void AboutDeposit_Load(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "select concat(last_name_customer, ' ', first_name_customer, ' ', middle_name), bank_account from customersDeposits, customers where customers.id_customer = customersDeposits.customer_id and id_customer_deposit = @id_dep;";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@id_dep", Global.deposit);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string name = reader.GetString(0);
                                string bankAccount = reader.GetString(1);

                                lblFIO.Text = name;
                                lblBankAccount.Text = bankAccount;
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
