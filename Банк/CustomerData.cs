using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Банк
{
    class CustomerData
    {
        public int id_customer { set; get; }
        public string first_name_customer { set; get; }
        public string last_name_customer { set; get; }
        public string middle_name { set; get; }
        public DateTime date_birth { set; get; }
        public string passport_customer { set; get; }
        public string address_customer { set; get; }
        public string telephone_customer { set; get; }
        public string email_customer { set; get; }
        public int social_status { set; get; }

        SqlConnection connect = new SqlConnection("Data Source=ACER-NITRO-5-49\\SQLEXPRESS;Initial Catalog=bank;Integrated Security=True");

        public List<CustomerData> customerListData()
        {
            List<CustomerData> listdata = new List<CustomerData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "select * from customers";

                    using(SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            CustomerData ed = new CustomerData();
                            ed.id_customer = (int)reader["id_customer"];
                            ed.first_name_customer = reader["first_name_customer"].ToString();
                            ed.last_name_customer = reader["last_name_customer"].ToString();
                            ed.middle_name = reader["middle_name"].ToString();
                            ed.date_birth = (DateTime)reader["date_birth"];
                            ed.passport_customer = reader["passport_customer"].ToString();
                            ed.address_customer = reader["address_customer"].ToString();
                            ed.telephone_customer = reader["telephone_customer"].ToString();
                            ed.email_customer = reader["email_customer"].ToString();
                            ed.social_status = (int)reader["social_status"];

                            listdata.Add(ed);
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Ошибка" + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }
    }
}
