using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Банк.MainDisplay;

namespace Банк
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void currentTime_Tick(object sender, EventArgs e)
        {
            var time = DateTime.Now.ToString("HH:mm:ss");
            lblCurrentTime.Text = time;
        }

        private void LoadForm(object Form)
        {
            if (Global.pn.Controls.Count > 0)
                Global.pn.Controls.RemoveAt(0);
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            Global.pn.Controls.Add(form);
            Global.pn.Tag = form;
            form.Show();
        }

        private void lblAddCustomer_Click(object sender, EventArgs e)
        {
            LoadForm(new FormAddCustomer());
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.Silver;
            Cursor = Cursors.Hand;
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.White;
            Cursor = Cursors.Default;
        }

        SqlConnection connect = new SqlConnection(Global.database);

        private void Home_Load(object sender, EventArgs e)
        {
            currentTime.Start();
            var date = DateTime.Now.ToString("d");
            lblDate.Text = date;

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "select first_name_emp, last_name_emp, name_post from bankStaff, posts where emp_number = @account and posts.id_post = bankStaff.post_id;";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@account", Global.account);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string employee = reader.GetString(1) + " " + reader.GetString(0) + " | " + reader.GetString(2);

                                lblName.Text = employee;
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

        private void lblFindCustomer_Click(object sender, EventArgs e)
        {
            LoadForm(new FindCustomer());
        }
    }
}
