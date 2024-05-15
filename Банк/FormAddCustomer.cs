using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static Банк.MainDisplay;

namespace Банк
{
    public partial class FormAddCustomer : Form
    {
        SqlConnection connect = new SqlConnection(Global.database);

        public FormAddCustomer()
        {
            InitializeComponent();
        }

        private void FormAddCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
            System.Windows.Forms.TextBox text = (System.Windows.Forms.TextBox)sender;

            if (text.Text.Length == 1)
                text.Text = text.Text.ToUpper();
            text.Select(text.Text.Length, 0);
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            string @char;

            @char = e.KeyChar.ToString();
            if (!Regex.Match(@char, @"[а-яА-ЯЁё0-9\.]").Success && !Regex.Match(@char, @"\s").Success)
            {
                e.Handled = true;
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

        private void maskedText_Click(object sender, EventArgs e)
        {
            MaskedTextBox maskedText = (MaskedTextBox)sender;
            maskedText.Select(0, 0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtLastName.Text == "" || txtMiddleName.Text == "" ||
                mTxtDateBirth.Text == "" || mTxtPassport.Text == "" || txtAddress.Text == "" ||
                mTxtTelephone.Text == "" || txtEmail.Text == "" || cmbStatus.Text == "" ||
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

                            string checkCustomerPassport = "select count(*) from customers where passport_customer = @passport_customer";

                            using (SqlCommand checkCust = new SqlCommand(checkCustomerPassport, connect))
                            {
                                checkCust.Parameters.AddWithValue("@passport_customer", mTxtPassport.Text.Trim());
                                int count = (int)checkCust.ExecuteScalar();

                                if (count >= 1)
                                {
                                    MessageBox.Show("Такой клиент уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    Image image = pictBox.Image;
                                    byte[] mas;
                                    ImageConverter converter = new ImageConverter();
                                    mas = (byte[])converter.ConvertTo(image, typeof(byte[]));


                                    string insertData = "insert into customers " +
                                        "(first_name_customer, last_name_customer, middle_name, date_birth, passport_customer, address_customer, telephone_customer, email_customer, social_status, photo, place_passport, date_passport)" +
                                        "values (@first_name_customer, @last_name_customer, @middle_name, @date_birth, @passport_customer, @address_customer, @telephone_customer, @email_customer, @social_status, @photo, @place_passport, @date_passport)";

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
                                        cmd.Parameters.AddWithValue("@social_status", cmbStatus.SelectedValue);
                                        cmd.Parameters.AddWithValue("@photo", mas);
                                        cmd.Parameters.AddWithValue("@place_passport", txtPassportPlace.Text);
                                        cmd.Parameters.AddWithValue("@date_passport", mTxtPassportDate.Text);

                                        cmd.ExecuteNonQuery();

                                        MessageBox.Show("Успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
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

        private void FormAddCustomer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataSet1.social_statuses". При необходимости она может быть перемещена или удалена.
            this.social_statusesTableAdapter.Fill(this.bankDataSet1.social_statuses);

            pictBox.Load(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 10) + "\\Resources\\user.png");
            photoName = pictBox.ImageLocation.ToString();
            photoName = photoName.Substring(photoName.LastIndexOf("\\"));
            photoName = photoName.Remove(0, 1);
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

        string photoName;

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

        private void mTxtDateBirth_Validating_1(object sender, CancelEventArgs e)
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

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
