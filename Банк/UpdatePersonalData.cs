﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Банк.MainDisplay;

namespace Банк
{
    public partial class UpdatePersonalData : Form
    {
        public UpdatePersonalData()
        {
            InitializeComponent();
        }

        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string @char;

            @char = e.KeyChar.ToString();
            if (!Regex.Match(@char, @"[а-яА-ЯЁё]").Success && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;

            if (text.Text.Length == 1)
                text.Text = text.Text.ToUpper();
            text.Select(text.Text.Length, 0);
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

        private void txtMiddleName_Validating(object sender, CancelEventArgs e)
        {
            if (txtMiddleName.Text == "")
            {
                lblMiddleName.Text = "Заполните поле";
                lblMiddleName.ForeColor = Color.Red;
                txtMiddleName.ForeColor = Color.Red;
                txtMiddleName.Select(0, txtMiddleName.Text.Length);
            }
            else
            {
                lblMiddleName.Text = "Отчество";
                lblMiddleName.ForeColor = Color.FromArgb(23, 24, 29);
                txtMiddleName.ForeColor = Color.Green;
            }
        }

        private void mTxtDateBirth_Validating(object sender, CancelEventArgs e)
        {
            bool check;
            DateTime scheduleDate;

            if (DateTime.TryParse(mTxtDateBirth.Text, out scheduleDate))
            {
                if (Convert.ToInt32(mTxtDateBirth.Text.Substring(0, 4)) < 1900 || scheduleDate > DateTime.Today)
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

        private void maskedText_Click(object sender, EventArgs e)
        {
            MaskedTextBox maskedText = (MaskedTextBox)sender;
            maskedText.Select(0, 0);
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

        private void mTxtTelephone_Click(object sender, EventArgs e)
        {
            MaskedTextBox maskedText = (MaskedTextBox)sender;
            maskedText.Select(4, 0);
        }

        private void mTxtTelephone_Validating(object sender, CancelEventArgs e)
        {
            if (mTxtTelephone.Text.Length != 18)
            {
                lblTelephone.Text = "Неверные данные";
                lblTelephone.ForeColor = Color.Red;
                mTxtTelephone.ForeColor = Color.Red;
                mTxtTelephone.Select(0, mTxtTelephone.Text.Length);
            }
            else
            {
                lblTelephone.Text = "Паспорт";
                lblTelephone.ForeColor = Color.FromArgb(23, 24, 29);
                mTxtTelephone.ForeColor = Color.Green;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidEmailAddress(txtEmail.Text))
            {
                lblEmail.Text = "Неверная почта";
                lblEmail.ForeColor = Color.Red;
                txtEmail.ForeColor = Color.Red;
                txtEmail.Select(0, txtEmail.Text.Length);
            }
            else
            {
                lblEmail.Text = "Почта";
                lblEmail.ForeColor = Color.FromArgb(23, 24, 29);
                txtEmail.ForeColor = Color.Green;
            }
        }

        private bool ValidEmailAddress(string email)
        {
            string regexPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$";
            return Regex.IsMatch(email, regexPattern);
        }

        private void cmbSocialStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        string photoName;

        private void UpdatePersonalData_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataSet1.social_statuses". При необходимости она может быть перемещена или удалена.
            this.social_statusesTableAdapter.Fill(this.bankDataSet1.social_statuses);

            pictBox.Load(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 10) + "\\Resources\\user.png");
            photoName = pictBox.ImageLocation.ToString();
            photoName = photoName.Substring(photoName.LastIndexOf("\\"));
            photoName = photoName.Remove(0, 1);

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "select first_name_customer, last_name_customer, middle_name, date_birth, passport_customer, address_customer, telephone_customer, email_customer, name_socal_status, photo, place_passport, date_passport from customers, social_statuses where social_statuses.id_social_status = customers.social_status and passport_customer = @passport";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@passport", Number.passport_customer);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string name = reader.GetString(0);
                                string lastName = reader.GetString(1);
                                string middleName = reader.GetString(2);
                                string dateBirth = reader.GetDateTime(3).ToString("yyyy-MM-dd");
                                string address = reader.GetString(5);
                                string telephone = reader.GetString(6);
                                string email = reader.GetString(7);
                                string status = reader.GetString(8);
                                byte[] image = (byte[])reader.GetValue(9);
                                MemoryStream memoryStream = new MemoryStream(image);
                                string place_passport = reader.GetString(10);
                                string date_passport = reader.GetDateTime(11).ToString("yyyy-MM-dd");

                                txtName.Text = name;
                                txtLastName.Text = lastName;
                                txtMiddleName.Text = middleName;
                                mTxtDateBirth.Text = dateBirth;
                                mTxtPassport.Text = Number.passport_customer;
                                txtAddress.Text = address;
                                mTxtTelephone.Text = telephone;
                                txtEmail.Text = email;
                                cmbSocialStatus.Text = status;
                                pictBox.Image = Image.FromStream(memoryStream);
                                txtPassportPlace.Text = place_passport;
                                mTxtPassportDate.Text = date_passport;
                            }
                        }
                    }
                    photoName = null;
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

        SqlConnection connect = new SqlConnection(Global.database);

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtLastName.Text == "" || txtMiddleName.Text == "" ||
                mTxtDateBirth.Text == "" || mTxtPassport.Text == "" || txtAddress.Text == "" ||
                mTxtTelephone.Text == "" || txtEmail.Text == "" || cmbSocialStatus.Text == "" ||
                mTxtPassportDate.Text == "" || txtPassportPlace.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (photoName == "user.png")
                {
                    MessageBox.Show("Пожалуйста, добавьте фотографию клиента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();

                            Image image = pictBox.Image;
                            byte[] mas;
                            ImageConverter converter = new ImageConverter();
                            mas = (byte[])converter.ConvertTo(image, typeof(byte[]));

                            string insertData = "update customers set first_name_customer = @first_name_customer, last_name_customer = @last_name_customer, middle_name = @middle_name, date_birth = @date_birth, passport_customer = @passport_customer, address_customer = @address_customer, telephone_customer = @telephone_customer, email_customer = @email_customer, social_status = @social_status, photo = @photo, place_passport = @place_passport, date_passport = @date_passport where passport_customer = @passport_customer;";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@first_name_customer", txtName.Text.Trim());
                                cmd.Parameters.AddWithValue("@last_name_customer", txtLastName.Text.Trim());
                                cmd.Parameters.AddWithValue("@middle_name", txtMiddleName.Text.Trim());
                                cmd.Parameters.AddWithValue("@date_birth", mTxtDateBirth.Text.Trim());
                                cmd.Parameters.AddWithValue("@passport_customer", mTxtPassport.Text.Trim());
                                cmd.Parameters.AddWithValue("@address_customer", txtAddress.Text.Trim());
                                cmd.Parameters.AddWithValue("@telephone_customer", mTxtTelephone.Text.Trim());
                                cmd.Parameters.AddWithValue("@email_customer", txtEmail.Text.Trim());
                                cmd.Parameters.AddWithValue("@social_status", cmbSocialStatus.SelectedValue);
                                cmd.Parameters.AddWithValue("@photo", mas);
                                cmd.Parameters.AddWithValue("@place_passport", txtPassportPlace.Text);
                                cmd.Parameters.AddWithValue("@date_passport", mTxtPassportDate.Text);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadForm(new CustomerAccount());
                                Global.btn.PerformClick();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка:" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
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

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(* .jpg; * .jpeg; * .png;)|* .jpg; * .jpeg; * .png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictBox.Image = new Bitmap(openFileDialog.FileName);
            }
            photoName = Path.GetFileName(openFileDialog.FileName);
        }

        private void mTxtPassportDate_Validating(object sender, CancelEventArgs e)
        {
            bool check;
            DateTime scheduleDate;

            if (DateTime.TryParse(mTxtPassportDate.Text, out scheduleDate))
            {
                if (Convert.ToInt32(mTxtPassportDate.Text.Substring(0, 4)) < 1900 || scheduleDate > DateTime.Today)
                    check = false;
                else check = true;
            }
            else check = false;

            if (mTxtPassportDate.Text.Length != 10 || check == false)
            {
                lblPassportDate.Text = "Неправильно введённая дата выдачи";
                lblPassportDate.ForeColor = Color.Red;
                mTxtPassportDate.ForeColor = Color.Red;
                mTxtPassportDate.Select(0, mTxtPassportDate.Text.Length);
            }
            else
            {
                lblPassportDate.Text = "Дата выдачи";
                lblPassportDate.ForeColor = Color.FromArgb(23, 24, 29);
                mTxtPassportDate.ForeColor = Color.Green;
            }
        }

        private void txtPassportPlace_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassportPlace.Text == "")
            {
                lblPassportPlace.Text = "Заполните поле";
                lblPassportPlace.ForeColor = Color.Red;
                txtPassportPlace.ForeColor = Color.Red;
                txtPassportPlace.Select(0, txtLastName.Text.Length);
            }
            else
            {
                lblPassportPlace.Text = "Место выдачи";
                lblPassportPlace.ForeColor = Color.FromArgb(23, 24, 29);
                txtPassportPlace.ForeColor = Color.Green;
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (txtAddress.Text == "")
            {
                lblAddress.Text = "Заполните поле";
                lblAddress.ForeColor = Color.Red;
                txtAddress.ForeColor = Color.Red;
                txtAddress.Select(0, txtAddress.Text.Length);
            }
            else
            {
                lblAddress.Text = "Адрес";
                lblAddress.ForeColor = Color.FromArgb(23, 24, 29);
                txtAddress.ForeColor = Color.Green;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            string @char;

            @char = e.KeyChar.ToString();
            if (!Regex.Match(@char, @"[a-zA-Z0-9\.@]").Success && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
