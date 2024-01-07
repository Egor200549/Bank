using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Банк.MainDisplay;

namespace Банк
{
    public partial class FindCustomer : Form
    {
        public FindCustomer()
        {
            InitializeComponent();
        }

        private void FindCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text == "")
            {
                lblName.Text = "Заполните поле";
                lblName.ForeColor = Color.Red;
                txtName.ForeColor = Color.Red;
                txtName.Select(0, txtName.Text.Length);
            }
            else
            {
                lblName.Text = "Имя";
                lblName.ForeColor = Color.FromArgb(23, 24, 29);
                txtName.ForeColor = Color.Green;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;

            if (text.Text.Length == 1)
                text.Text = text.Text.ToUpper();
            text.Select(text.Text.Length, 0);

            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Имя like '{0}%'", txtName.Text);
        }

        bool backspace;

        private void textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
                backspace = true;
        }

        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!backspace)
            {
                string @char;

                @char = e.KeyChar.ToString();
                if (!Regex.Match(@char, @"[а-яА-ЯЁё]").Success)
                {
                    e.Handled = true;
                }
            }
        }

        private void maskedText_Click(object sender, EventArgs e)
        {
            MaskedTextBox maskedText = (MaskedTextBox)sender;
            maskedText.Select(0, 0);
        }

        private void mTxtDateBirth_Validating(object sender, CancelEventArgs e)
        {
            bool check;
            DateTime scheduleDate;

            if (DateTime.TryParse(mTxtDateBirth.Text, out scheduleDate))
            {
                if (Convert.ToInt32(mTxtDateBirth.Text.Substring(0, 4)) < 1900)
                    check = false;
                else check = true;
            }
            else check = false;

            if (mTxtDateBirth.Text.Length != 10 || check == false)
            {
                lblDateBirth.Text = "Неверная дата";
                lblDateBirth.ForeColor = Color.Red;
                mTxtDateBirth.ForeColor = Color.Red;
                mTxtDateBirth.Select(0, mTxtDateBirth.Text.Length);
            }
            else
            {
                lblDateBirth.Text = "Дата рождения";
                lblDateBirth.ForeColor = Color.FromArgb(23, 24, 29);
                mTxtDateBirth.ForeColor = Color.Green;
            }
        }

        private void mTxtPassport_Validating(object sender, CancelEventArgs e)
        {
            if (mTxtPassport.Text.Length != 12)
            {
                lblPassport.Text = "Неверные данные";
                lblPassport.ForeColor = Color.Red;
                mTxtPassport.ForeColor = Color.Red;
                mTxtDateBirth.Select(0, mTxtPassport.Text.Length);
            }
            else
            {
                lblPassport.Text = "Паспорт";
                lblPassport.ForeColor = Color.FromArgb(23, 24, 29);
                mTxtPassport.ForeColor = Color.Green;
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (txtLastName.Text == "")
            {
                lblLastName.Text = "Заполните поле";
                lblLastName.ForeColor = Color.Red;
                txtLastName.ForeColor = Color.Red;
                txtLastName.Select(0, txtLastName.Text.Length);
            }
            else
            {
                lblLastName.Text = "Фамилия";
                lblLastName.ForeColor = Color.FromArgb(23, 24, 29);
                txtLastName.ForeColor = Color.Green;
            }
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

        SqlConnection connect = new SqlConnection(Global.database);

        private void FindCustomer_Load(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "select id_customer, last_name_customer as Фамилия, first_name_customer as Имя, date_birth as 'Дата рождения', passport_customer as Паспорт from customers";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dataGridView1.DataSource = table;
                        dataGridView1.Columns[0].Visible = false;
                        dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;

            if (text.Text.Length == 1)
                text.Text = text.Text.ToUpper();
            text.Select(text.Text.Length, 0);

            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Фамилия like '{0}%'", txtLastName.Text);
        }

        private void mTxtPassport_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Паспорт like '{0}%'", mTxtPassport.Text);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Number.passport_customer  = dataGridView1.SelectedRows[0].Cells[4].Value.ToString().Trim();
            LoadForm(new CustomerAccount());
        }
    }
}