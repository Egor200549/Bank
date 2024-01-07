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

        SqlConnection connect = new SqlConnection(Global.database);

        private void CustomerAccount_Load(object sender, EventArgs e)
        {
            Global.pnDeposit = pnMain;

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
            btnDisplayDeposit.BackColor = Color.WhiteSmoke;
            btnDisplayDeposit.ForeColor = Color.FromArgb(23, 24, 29);
            btnDisplayDeposit.FlatAppearance.BorderColor = Color.Silver;

            btnCredit.BackColor = Color.WhiteSmoke;
            btnCredit.ForeColor = Color.FromArgb(23, 24, 29);
            btnCredit.FlatAppearance.BorderColor = Color.Silver;
            btnDisplayCredit.BackColor = Color.WhiteSmoke;
            btnDisplayCredit.ForeColor = Color.FromArgb(23, 24, 29);
            btnDisplayCredit.FlatAppearance.BorderColor = Color.Silver;

            btnPersonalData.BackColor = Color.FromArgb(23, 24, 29);
            btnPersonalData.ForeColor = Color.WhiteSmoke;
            btnPersonalData.FlatAppearance.BorderColor = Color.FromArgb(23, 24, 29);
            btnDisplayPersonalData.BackColor = Color.FromArgb(23, 24, 29);
            btnDisplayPersonalData.ForeColor = Color.WhiteSmoke;
            btnDisplayPersonalData.FlatAppearance.BorderColor = Color.FromArgb(23, 24, 29);
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
                    btnDisplayDeposit.Text = "▼";
                }
            }
            else
            {
                flpnDeposit.Height += 10;
                if (flpnDeposit.Height == flpnDeposit.MaximumSize.Height)
                {
                    depositMenu = true;
                    timerDeposit.Stop();
                    btnDisplayDeposit.Text = "▲";
                }
            }
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            btnDeposit.BackColor = Color.WhiteSmoke;
            btnDeposit.ForeColor = Color.FromArgb(23, 24, 29);
            btnDeposit.FlatAppearance.BorderColor = Color.Silver;
            btnDisplayDeposit.BackColor = Color.WhiteSmoke;
            btnDisplayDeposit.ForeColor = Color.FromArgb(23, 24, 29);
            btnDisplayDeposit.FlatAppearance.BorderColor = Color.Silver;

            btnPersonalData.BackColor = Color.WhiteSmoke;
            btnPersonalData.ForeColor = Color.FromArgb(23, 24, 29);
            btnPersonalData.FlatAppearance.BorderColor = Color.Silver;
            btnDisplayPersonalData.BackColor = Color.WhiteSmoke;
            btnDisplayPersonalData.ForeColor = Color.FromArgb(23, 24, 29);
            btnDisplayPersonalData.FlatAppearance.BorderColor = Color.WhiteSmoke;

            btnCredit.BackColor = Color.FromArgb(23, 24, 29);
            btnCredit.ForeColor = Color.WhiteSmoke;
            btnCredit.FlatAppearance.BorderColor = Color.FromArgb(23, 24, 29);
            btnDisplayCredit.BackColor = Color.FromArgb(23, 24, 29);
            btnDisplayCredit.ForeColor = Color.WhiteSmoke;
            btnDisplayCredit.FlatAppearance.BorderColor = Color.FromArgb(23, 24, 29);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            btnPersonalData.BackColor = Color.WhiteSmoke;
            btnPersonalData.ForeColor = Color.FromArgb(23, 24, 29);
            btnPersonalData.FlatAppearance.BorderColor = Color.Silver;
            btnDisplayPersonalData.BackColor = Color.WhiteSmoke;
            btnDisplayPersonalData.ForeColor = Color.FromArgb(23, 24, 29);
            btnDisplayPersonalData.FlatAppearance.BorderColor = Color.WhiteSmoke;

            btnCredit.BackColor = Color.WhiteSmoke;
            btnCredit.ForeColor = Color.FromArgb(23, 24, 29);
            btnCredit.FlatAppearance.BorderColor = Color.Silver;
            btnDisplayCredit.BackColor = Color.WhiteSmoke;
            btnDisplayCredit.ForeColor = Color.FromArgb(23, 24, 29);
            btnDisplayCredit.FlatAppearance.BorderColor = Color.Silver;

            btnDeposit.BackColor = Color.FromArgb(23, 24, 29);
            btnDeposit.ForeColor = Color.WhiteSmoke;
            btnDeposit.FlatAppearance.BorderColor = Color.FromArgb(23, 24, 29);
            btnDisplayDeposit.BackColor = Color.FromArgb(23, 24, 29);
            btnDisplayDeposit.ForeColor = Color.WhiteSmoke;
            btnDisplayDeposit.FlatAppearance.BorderColor = Color.FromArgb(23, 24, 29);

            LoadForm(new DepositCustomer());
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
                    btnDisplayCredit.Text = "▼";
                }
            }
            else
            {
                flpnCredit.Height += 10;
                if (flpnCredit.Height == flpnCredit.MaximumSize.Height)
                {
                    creditMenu = true;
                    timerCredit.Stop();
                    btnDisplayCredit.Text = "▲";
                }
            }
        }

        private void btnDisplayDeposit_Click(object sender, EventArgs e)
        {
            timerDeposit.Start();
        }

        private void btnDisplayCredit_Click(object sender, EventArgs e)
        {
            timerCredit.Start();
        }

        bool dataMenu;

        private void timerPersonalData_Tick(object sender, EventArgs e)
        {
            if (dataMenu)
            {
                flpnPersonalData.Height -= 10;
                if (flpnPersonalData.Height == flpnPersonalData.MinimumSize.Height)
                {
                    dataMenu = false;
                    timerPersonalData.Stop();
                    btnDisplayPersonalData.Text = "▼";
                }
            }
            else
            {
                flpnPersonalData.Height += 10;
                if (flpnPersonalData.Height == flpnPersonalData.MaximumSize.Height)
                {
                    dataMenu = true;
                    timerPersonalData.Stop();
                    btnDisplayPersonalData.Text = "▲";
                }
            }
        }

        private void btnDisplayPersonalData_Click(object sender, EventArgs e)
        {
            timerPersonalData.Start();
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            LoadForm(new UpdatePersonalData());
        }
    }
}
