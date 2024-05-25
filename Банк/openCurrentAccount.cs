using System;
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
    public partial class openCurrentAccount : Form
    {
        public openCurrentAccount()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(Global.database);
        string signCurrency = "";
        double max_sum;
        double min_sum;
        double percentage;
        int min_period_dep;
        int max_period_dep;

        private void openCurrentAccount_Load(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "select name_deposit_default, name_currency, min_period_dep, max_period_dep, deposit_percentange, min_sum, max_sum, iif(contribution = 1, 'Разрешено', 'Не разрешено'), iif(write_off = 1, 'Разрешено', 'Не разрешено'), name_interest, early_percentage, dif_percentage, iif(prolongation = 1, 'Да', 'Нет') as prolongation from deposits, interestPaymentsDep, currencies where deposits.interest_dep = interestPaymentsDep.id_interest_dep and currencies.currency_code = deposits.currency_code and id_deposit = @id_dep;";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@id_dep", Global.openDeposit);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string name = reader.GetString(0);
                                string currency = reader.GetString(1);
                                min_period_dep = reader.GetInt32(2);
                                max_period_dep = reader.GetInt32(3);
                                percentage = reader.GetDouble(4);
                                min_sum = reader.GetSqlMoney(5).ToDouble();
                                max_sum = reader.GetSqlMoney(6).ToDouble();
                                string contribution = reader.GetString(7);
                                string write_off = reader.GetString(8);
                                string name_interest = reader.GetString(9);
                                double early_percentage = reader.GetDouble(10);
                                double dif_percentage = reader.GetDouble(11);
                                string prolongation = reader.GetString(12);

                                lblName.Text = "Открыть " + name;
                                txtSum.Text = min_sum.ToString("N");
                                lblPercentage.Text = percentage.ToString() + "%";
                                txtPeriod.Text = min_period_dep.ToString();

                                if (contribution == "Не разрешено")
                                {
                                    checkBox2.Visible = false;
                                }

                                if (contribution == "Не разрешено")
                                {
                                    checkBox1.Visible = false;
                                }

                                if (checkBox1.Visible == false && checkBox2.Visible == false)
                                {
                                    flowLayoutPanel1.Visible = false;
                                    flowLayoutPanel2.Padding = new Padding(20, 20, 20, 10);
                                }

                                if (currency == "CNY")
                                {
                                    signCurrency = "¥";
                                }
                                else if (currency == "RUB")
                                {
                                    signCurrency = "₽";
                                }
                                else if (currency == "AED")
                                {
                                    signCurrency = "dh";
                                }
                                else if (currency == "USD")
                                {
                                    signCurrency = "$";
                                }
                                else if (currency == "EUR")
                                {
                                    signCurrency = "€";
                                }

                                lblMaxSum.Text = "макс. сумма: " + max_sum.ToString("N") + " " + signCurrency;
                                lblMinSum.Text = "мин. сумма: " + min_sum.ToString("N") + " " + signCurrency;
                                lblMaxPeriod.Text = "макс. период: " + max_period_dep + " мес.";
                                lblMinPeriod.Text = "мин. период: " + min_period_dep + " мес.";
                                label5.Text = $"Сумма вклада в конце периода за {min_period_dep} мес.";

                                double return_sum = double.Parse(txtSum.Text);

                                for (int i = 0; i < int.Parse(txtPeriod.Text); i++)
                                {
                                    return_sum += return_sum / 100 * percentage / 12;
                                }
                                lblReturnSum.Text = return_sum.ToString("N") + " " + signCurrency;
                                lblIncome.Text = "+ " + (return_sum - double.Parse(txtSum.Text)).ToString("N") + " " + signCurrency;
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

        private void lblGoBack_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.Silver;
            Cursor = Cursors.Hand;
        }

        private void lblGoBack_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.White;
            Cursor = Cursors.Default;
        }

        private void lblGoBack_Click(object sender, EventArgs e)
        {
            LoadForm(new openAccount());
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

        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
        }

        private void txtSum_TextChanged(object sender, EventArgs e)
        {
            if (txtSum.Text != "" && (double.Parse(txtSum.Text) > max_sum || double.Parse(txtSum.Text) < min_sum))
            {
                txtSum.ForeColor = Color.Red;
            }
            else
            {
                txtSum.ForeColor = Color.Black;
                if (checkTextBoxs())
                {
                    count();
                }
            }
        }

        private void txtPeriod_TextChanged(object sender, EventArgs e)
        {
            if (txtPeriod.Text != "" && (int.Parse(txtPeriod.Text) > max_period_dep || int.Parse(txtPeriod.Text) < min_period_dep))
            {
                txtPeriod.ForeColor = Color.Red;
            }
            else
            {
                txtPeriod.ForeColor = Color.Black;
                label5.Text = $"Сумма вклада в конце периода за {txtPeriod.Text} мес.";
                if (checkTextBoxs())
                {
                    count();
                }
            }
        }

        private bool checkTextBoxs()
        {
            if (txtSum.Text == "" || txtPeriod.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void count()
        {
            double return_sum = double.Parse(txtSum.Text);

            for (int i = 0; i < int.Parse(txtPeriod.Text); i++)
            {
                return_sum += return_sum / 100 * percentage / 12;
            }
            lblReturnSum.Text = return_sum.ToString("N") + " " + signCurrency;
            lblIncome.Text = "+ " + (return_sum - double.Parse(txtSum.Text)).ToString("N") + " " + signCurrency;
        }

        private void txtSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (txtSum.Text == "" || txtPeriod.Text == "" || double.Parse(txtSum.Text) > max_sum || double.Parse(txtSum.Text) < min_sum ||
                int.Parse(txtPeriod.Text) > max_period_dep || int.Parse(txtPeriod.Text) < min_period_dep)
            {
                MessageBox.Show("Вклад не соответствует условиям банка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Global.openDepositSum = double.Parse(txtSum.Text);
                Global.openDepositPeriod = int.Parse(txtPeriod.Text);
                LoadForm(new openingDeposit());
            }
        }

        private void txtSum_Enter(object sender, EventArgs e)
        {
            if (txtSum.Text == min_sum.ToString("N"))
            {
                txtSum.Text = "";
            }
        }

        private void txtSum_Leave(object sender, EventArgs e)
        {
            if (txtSum.Text == "")
            {
                txtSum.Text = min_sum.ToString("N");
            }
        }

        private void txtPeriod_Enter(object sender, EventArgs e)
        {
            if (txtPeriod.Text == min_period_dep.ToString())
            {
                txtPeriod.Text = "";
            }
        }

        private void txtPeriod_Leave(object sender, EventArgs e)
        {
            if (txtPeriod.Text == "")
            {
                txtPeriod.Text = min_period_dep.ToString();
            }
        }

        private void txtPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
