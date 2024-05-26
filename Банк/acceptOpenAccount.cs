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
    public partial class acceptOpenAccount : Form
    {
        public acceptOpenAccount()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(Global.database);
        int id_customer;
        int id_emp;

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "select id_customer from customers where passport_customer = @passport";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@passport", Number.passport_customer);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                id_customer = reader.GetInt32(0);
                            }
                            reader.Close();
                        }
                    }

                    string selectData2 = "select id_emp from bankStaff where emp_number = @id_emp;";

                    using (SqlCommand cmd = new SqlCommand(selectData2, connect))
                    {
                        cmd.Parameters.AddWithValue("@id_emp", Global.employee_account);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                id_emp = reader.GetInt32(0);
                            }
                            reader.Close();
                        }
                    }

                    string insertData = "insert into customersDeposits (customer_id, emp_id, deposit_id, period_dep, deposit_amount) values (@customer_id, @emp_id, @deposit_id, null, 0);";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@customer_id", id_customer);
                        cmd.Parameters.AddWithValue("@emp_id", id_emp);
                        cmd.Parameters.AddWithValue("@deposit_id", Global.openAccount);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Счет успешно открыт", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadForm(new AccountsCustomer());
                        this.Hide();
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
    }
}
