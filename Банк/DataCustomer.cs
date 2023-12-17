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
    public partial class DataCustomer : Form
    {
        public DataCustomer()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=ACER-NITRO-5-49\\SQLEXPRESS;Initial Catalog=bank;Integrated Security=True");

        private void DataCustomer_Load(object sender, EventArgs e)
        {


            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "select first_name_customer, last_name_customer, middle_name, date_birth, passport_customer, address_customer, telephone_customer, email_customer, name_socal_status from customers, social_statuses where social_statuses.id_social_status = customers.social_status and passport_customer = @passport";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@passport", Number.passport_customer);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string name = reader.GetString(1) + " " + reader.GetString(0) + " " +
                                    reader.GetString(2);
                                string dateBirth = reader.GetDateTime(3).ToString("yyyy-MM-dd");
                                string address = reader.GetString(5);
                                string telephone = reader.GetString(6);
                                string email = reader.GetString(7);
                                string status = reader.GetString(8);

                                mTxtDateBirth.Text = dateBirth;
                                mTxtPassport.Text = Number.passport_customer;
                                txtAddress.Text = address;
                                mTxtTelephone.Text = telephone;
                                txtEmail.Text = email;
                                txtStatus.Text = status;
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
