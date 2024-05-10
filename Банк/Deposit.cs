using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Банк.MainDisplay;

namespace Банк
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(Global.database);

        private void Deposit_Load(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "select name_deposit, deposit_percentange, deposit_amount, min_balance, min_sum, name_currency, iif(contribution = 1, 'Разрешено', 'Не разрешено'), iif(write_off = 1, 'Разрешено', 'Не разрешено'), current_percentage from customersDeposits, deposits, currencies where customersDeposits.deposit_id = deposits.id_deposit and currencies.currency_code = deposits.currency_code and id_customer_deposit = @id_dep;";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@id_dep", Global.deposit);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string name = reader.GetString(0);
                                string percentage = reader.GetDouble(1).ToString() + "%";
                                string sum = reader.GetSqlMoney(2).ToDouble().ToString("N");
                                string min_balance = reader.GetSqlMoney(3).ToDouble().ToString("N");
                                string min_sum;

                                try
                                {
                                    min_sum = reader.GetSqlMoney(4).ToDouble().ToString("N");
                                }
                                catch
                                {
                                    min_sum = "";
                                }
                                
                                string currency = reader.GetString(5);
                                string contribution = reader.GetString(6);
                                string write_off = reader.GetString(7);
                                string current_percentage = reader.GetDouble(8).ToString() + "%";

                                lblName.Text = name;
                                lblPercenrage.Text = current_percentage;
                                lblCurrency.Text = currency;
                                lblSum.Text = sum;

                                string signCurrency = "";

                                if (currency == "CNY")
                                {
                                    lblSum.Text += " ¥";
                                    signCurrency = "¥";
                                }
                                else if (currency == "RUB")
                                {
                                    lblSum.Text += " ₽";
                                    signCurrency = "₽";
                                }
                                else if (currency == "AED")
                                {
                                    lblSum.Text += " dh";
                                    signCurrency = "dh";
                                }
                                else if (currency == "USD")
                                {
                                    lblSum.Text += " $";
                                    signCurrency = "$";
                                }
                                else if (currency == "EUR")
                                {
                                    lblSum.Text += " €";
                                    signCurrency = "€";
                                }

                                if (write_off == "Разрешено" && Convert.ToDouble(percentage.Substring(0, percentage.Length - 1)) != 0)
                                {
                                    double sumD;
                                    double.TryParse(sum, out sumD);
                                    double min_sumD;
                                    double.TryParse(min_sum, out min_sumD);

                                    if (sumD > min_sumD)
                                        lblTransaction.Text += (sumD - min_sumD).ToString("N") + " " + signCurrency + " без изменения ставки";
                                    else
                                        lblTransaction.Text += "0 " + signCurrency + " без изменения ставки";

                                    double remains;
                                    double.TryParse(min_balance, out remains);
                                    lblRemains.Text += remains + " " + signCurrency + " (ставка " + current_percentage + ")";
                                }
                                else
                                {
                                    flowLayoutPanel5.Visible = false;
                                    pnAnotherTransfer.Visible = false;
                                    pnTransfer.Visible = false;
                                }

                                if (Convert.ToDouble(percentage.Substring(0, percentage.Length - 1)) == 0)
                                {
                                    расчётСтавкиToolStripMenuItem.Visible = false;
                                    pnAnotherTransfer.Visible = true;
                                    pnTransfer.Visible = true;
                                }

                                if (contribution != "Разрешено")
                                {
                                    pnAdd.Visible = false;
                                }
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

        private void label_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.DimGray;
            Cursor = Cursors.Hand;
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.Black;
            Cursor = Cursors.Default;
        }

        private void LoadForm(object Form)
        {
            if (pnAboutDeposit.Controls.Count > 0)
                pnAboutDeposit.Controls.RemoveAt(0);
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnAboutDeposit.Controls.Add(form);
            pnAboutDeposit.Tag = form;
            form.Show();
        }

        private void реквизитыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new AboutDeposit());
            AboutDeposit form = new AboutDeposit();
            pnAboutDeposit.Size = new Size(pnAboutDeposit.Width, form.Height);
        }

        private void ToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.BackColor = Color.Silver;
        }

        private void ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.BackColor = Color.WhiteSmoke;
        }

        private void расчётСтавкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new rateCalculation());
            rateCalculation form = new rateCalculation();
            pnAboutDeposit.Size = new Size(pnAboutDeposit.Width, form.Height);
        }

        private void информацияОСчеётеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new info_bank_account());
            info_bank_account form = new info_bank_account();
            pnAboutDeposit.Size = new Size(pnAboutDeposit.Width, form.Height);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Function(new TransferToAccount());
        }

        private void Function(object Form)
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
