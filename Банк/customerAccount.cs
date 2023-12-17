using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Банк.MainDisplay;

namespace Банк
{
    public partial class CustomerAccount : Form
    {
        public CustomerAccount()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=ACER-NITRO-5-49\\SQLEXPRESS;Initial Catalog=bank;Integrated Security=True");

        private void CustomerAccount_Load(object sender, EventArgs e)
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
                                string name = reader.GetString(1) + " " + reader.GetString(0) + " " + reader.GetString(2);
                                string dateBirth = reader.GetDateTime(3).ToString("yyyy-MM-dd");
                                string address = reader.GetString(5);
                                string telephone = reader.GetString(6);
                                string email = reader.GetString(7);
                                string status = reader.GetString(8);

                                lblFIO.Text = name;
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

        private void LoadForm(object Form)
        {
            if (pnMain.Controls.Count > 0)
                pnMain.Controls.RemoveAt(0);
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnMain.Controls.Add(form);
            pnMain.Tag = form;
            form.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnDeposit.BackColor = Color.WhiteSmoke;
            btnDeposit.ForeColor = Color.FromArgb(23, 24, 29);
            btnDeposit.FlatAppearance.BorderColor = Color.Silver;

            btnCredit.BackColor = Color.WhiteSmoke;
            btnCredit.ForeColor = Color.FromArgb(23, 24, 29);
            btnCredit.FlatAppearance.BorderColor = Color.Silver;

            btnPersonalData.BackColor = Color.FromArgb(23, 24, 29);
            btnPersonalData.ForeColor = Color.WhiteSmoke;
            btnPersonalData.FlatAppearance.BorderColor = Color.FromArgb(23, 24, 29);
            LoadForm(new DataCustomer());
        }

        bool depositMenu;

        private void timerDeposit_Tick(object sender, EventArgs e)
        {
            if (depositMenu)
            {
                flpnDeposit.Height -= 10;
                if (flpnDeposit.Height == flpnDeposit.MinimumSize.Height)
                {
                    depositMenu = false;
                    timerDeposit.Stop();
                }
            }
            else
            {
                flpnDeposit.Height += 10;
                if (flpnDeposit.Height == flpnDeposit.MaximumSize.Height)
                {
                    depositMenu = true;
                    timerDeposit.Stop();
                }
            }
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            btnDeposit.BackColor = Color.WhiteSmoke;
            btnDeposit.ForeColor = Color.FromArgb(23, 24, 29);
            btnDeposit.FlatAppearance.BorderColor = Color.Silver;

            btnPersonalData.BackColor = Color.WhiteSmoke;
            btnPersonalData.ForeColor = Color.FromArgb(23, 24, 29);
            btnPersonalData.FlatAppearance.BorderColor = Color.Silver;

            btnCredit.BackColor = Color.FromArgb(23, 24, 29);
            btnCredit.ForeColor = Color.WhiteSmoke;
            btnCredit.FlatAppearance.BorderColor = Color.FromArgb(23, 24, 29);
            //timerCredit.Start();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            btnPersonalData.BackColor = Color.WhiteSmoke;
            btnPersonalData.ForeColor = Color.FromArgb(23, 24, 29);
            btnPersonalData.FlatAppearance.BorderColor = Color.Silver;

            btnCredit.BackColor = Color.WhiteSmoke;
            btnCredit.ForeColor = Color.FromArgb(23, 24, 29);
            btnCredit.FlatAppearance.BorderColor = Color.Silver;

            btnDeposit.BackColor = Color.FromArgb(23, 24, 29);
            btnDeposit.ForeColor = Color.WhiteSmoke;
            btnDeposit.FlatAppearance.BorderColor = Color.FromArgb(23, 24, 29);
            //timerDeposit.Start();
        }

        bool creditMenu;

        private void timerCredit_Tick(object sender, EventArgs e)
        {
            if (creditMenu)
            {
                flpnCredit.Height -= 10;
                if (flpnCredit.Height == flpnCredit.MinimumSize.Height)
                {
                    creditMenu = false;
                    timerCredit.Stop();
                }
            }
            else
            {
                flpnCredit.Height += 10;
                if (flpnCredit.Height == flpnCredit.MaximumSize.Height)
                {
                    creditMenu = true;
                    timerCredit.Stop();
                }
            }
        }
    }
}
