﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;

            if (text.Text.Length == 1)
                text.Text = text.Text.ToUpper();
            text.Select(text.Text.Length, 0);
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
                lblDateBirth.Text = "Неправильно введённая дата рождения";
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

        SqlConnection connect = new SqlConnection("Data Source=ACER-NITRO-5-49\\SQLEXPRESS;Initial Catalog=bank;Integrated Security=True");

        private void button_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtLastName.Text == "" ||
                mTxtDateBirth.Text == "" || mTxtPassport.Text == "")
            {
                MessageBox.Show("Пожалйста, введите все данные", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectData = "select first_name_customer, last_name_customer, middle_name, date_birth, passport_customer, address_customer, telephone_customer, email_customer, name_socal_status from customers, social_statuses where social_statuses.id_social_status = customers.social_status and passport_customer = @passport";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            string passport = mTxtPassport.Text.Trim();
                            cmd.Parameters.AddWithValue("@passport", passport);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                Number.passport_customer = mTxtPassport.Text.Trim();
                                LoadForm(new CustomerAccount());
                            }
                            else
                            {
                                MessageBox.Show("Такого клиента не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
}
