using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static Банк.MainDisplay;

namespace Банк
{
    public partial class openDeposit : Form
    {
        public openDeposit()
        {
            InitializeComponent();
        }

        public class Deposit
        {
            public int id;
            public string name;
            public double deposit_percentage;
            public string contribution;
            public string write_off;
            public string interest_dep;

            public Deposit(int id, string name, double deposit_percentage, string contribution, string write_off,
                string interest_dep)
            {
                this.id = id;
                this.name = name;
                this.deposit_percentage = deposit_percentage;
                this.contribution = contribution;
                this.write_off = write_off;
                this.interest_dep = interest_dep;
            }
        }

        SqlConnection connect = new SqlConnection(Global.database);
        List<Deposit> deposit_list = new List<Deposit>();

        Color[] colors = { Color.LightGreen, Color.Khaki, Color.LightBlue, Color.Plum, Color.Pink, Color.PeachPuff };
        int color = 0;

        private void openAccount_Load(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "select * from deposits, interestPaymentsDep where deposits.interest_dep = interestPaymentsDep.id_interest_dep;";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Deposit deposit = new(
                                    int.Parse(reader["id_deposit"].ToString()),
                                    reader["name_deposit_default"].ToString(),
                                    double.Parse(reader["deposit_percentange"].ToString()),
                                    reader["contribution"].ToString(),
                                    reader["write_off"].ToString(),
                                    reader["name_interest"].ToString()
                                );
                                deposit_list.Add(deposit);
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

            for (int i = 0; i < deposit_list.Count; i++)
            {
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel()
                {
                    Name = $"flow{i}",
                    BackColor = colors[color],
                    AutoSize = true,
                    Margin = new Padding(0, 0, 20, 20),
                    MaximumSize = new Size(295, 0),
                    MinimumSize = new Size(295, 295),
                    Padding = new Padding(20),
                };

                color++;

                if (color > colors.Length - 1)
                {
                    color = 0;
                }

                flowLayoutPanel1.Controls.Add(flowLayoutPanel);

                Label name = new Label()
                {
                    Name = $"name{i}",
                    Font = new Font(new FontFamily("Century"), 14, FontStyle.Bold),
                    Text = deposit_list[i].name,
                    AutoSize = true,
                    Margin = new Padding(0, 0, 0, 20),
                    MaximumSize = new Size(255, 0),
                    MinimumSize = new Size(255, 0)
                };

                flowLayoutPanel1.Controls[$"flow{i}"].Controls.Add(name);

                string description = "Выплата процентов: " + deposit_list[i].interest_dep.ToLower() + "\nВозможность пополнять: ";

                if (deposit_list[i].contribution == "True")
                {
                    description += "есть\n";
                }
                else
                {
                    description += "нет\n";
                }

                description += "Возможность снимать: ";

                if (deposit_list[i].write_off == "True")
                {
                    description += "есть\n";
                }
                else
                {
                    description += "нет\n";
                }


                Label lblDescription = new Label()
                {
                    Name = $"lblDescription{i}",
                    Font = new Font(new FontFamily("Century"), 12, FontStyle.Regular),
                    Text = description,
                    AutoSize = true,
                    Margin = new Padding(0, 0, 0, 40),
                    MaximumSize = new Size(255, 0),
                    MinimumSize = new Size(255, 0)
                };

                flowLayoutPanel1.Controls[$"flow{i}"].Controls.Add(lblDescription);

                Label lblPercent = new Label()
                {
                    Name = $"lblPercent{i}",
                    Font = new Font(new FontFamily("Century"), 14, FontStyle.Bold),
                    Text = deposit_list[i].deposit_percentage.ToString() + "%",
                    AutoSize = true,
                    Margin = new Padding(0, 0, 0, 20),
                    MaximumSize = new Size(255, 0),
                    MinimumSize = new Size(255, 0)
                };

                flowLayoutPanel1.Controls[$"flow{i}"].Controls.Add(lblPercent);

                Button button = new Button()
                {
                    Name = $"button{i}",
                    Tag = deposit_list[i].id,
                    Font = new Font(new FontFamily("Century"), 12, FontStyle.Regular),
                    Text = "Оформить",
                    Margin = new Padding(0, 0, 0, 0),
                    Size = new Size(130, 45),
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 },
                    BackColor = Color.WhiteSmoke,
                };

                flowLayoutPanel1.Controls[$"flow{i}"].Controls.Add(button);
                flowLayoutPanel1.Controls[$"flow{i}"].Controls[$"button{i}"].Click += openCurrentAccount;
            }
        }

        private void openCurrentAccount(object sender, EventArgs e)
        {
            Global.openDeposit = int.Parse(((Button)sender).Tag.ToString());
            LoadForm(new openCurrentDeposit());
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
    }
}
