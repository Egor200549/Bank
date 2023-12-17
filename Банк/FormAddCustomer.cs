using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Банк
{
    public partial class FormAddCustomer : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=ACER-NITRO-5-49\\SQLEXPRESS;Initial Catalog=bank;Integrated Security=True");

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

        bool backspace;

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

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox text = (System.Windows.Forms.TextBox)sender;

            if (text.Text.Length == 1)
                text.Text = text.Text.ToUpper();
            text.Select(text.Text.Length, 0);
        }

        private void textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
                backspace = true;
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!backspace)
            {
                string @char;

                @char = e.KeyChar.ToString();
                if (!Regex.Match(@char, @"[а-яА-ЯЁё0-9\.]").Success && !Regex.Match(@char, @"\s").Success)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!backspace)
            {
                string @char;

                @char = e.KeyChar.ToString();
                if (!Regex.Match(@char, @"[a-zA-Z0-9\.@]").Success)
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

        private void mTxtTelephone_Click(object sender, EventArgs e)
        {
            MaskedTextBox maskedText = (MaskedTextBox)sender;
            maskedText.Select(4, 0);
        }

        private void cmbSocialStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtLastName.Text == "" || txtMiddleName.Text == "" ||
                mTxtDateBirth.Text == "" || mTxtPassport.Text == "" || txtAddress.Text == "" ||
                mTxtTelephone.Text == "" || txtEmail.Text == "" || cmbSocialStatus.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string checkCustomerPassport = "select count(*) from customers where passport_customer = @passport_customer";

                        using(SqlCommand checkCust = new SqlCommand(checkCustomerPassport, connect))
                        {
                            checkCust.Parameters.AddWithValue("@passport_customer", mTxtPassport.Text.Trim());
                            int count = (int)checkCust.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show("Такой клиент уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "insert into customers " +
                                    "(first_name_customer, last_name_customer, middle_name, date_birth, passport_customer, address_customer, telephone_customer, email_customer, social_status)" +
                                    "values (@first_name_customer, @last_name_customer, @middle_name, @date_birth, @passport_customer, @address_customer, @telephone_customer, @email_customer, @social_status)";

                                using(SqlCommand cmd = new SqlCommand(insertData, connect))
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

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch(Exception ex)
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

        private void FormAddCustomer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataSet1.social_statuses". При необходимости она может быть перемещена или удалена.
            this.social_statusesTableAdapter.Fill(this.bankDataSet1.social_statuses);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataSet1.social_statuses". При необходимости она может быть перемещена или удалена.
            this.social_statusesTableAdapter.Fill(this.bankDataSet1.social_statuses);

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
                lblMiddleName.Text = "Фамилия";
                lblMiddleName.ForeColor = Color.FromArgb(23, 24, 29);
                txtMiddleName.ForeColor = Color.Green;
            }
        }
    }
}
