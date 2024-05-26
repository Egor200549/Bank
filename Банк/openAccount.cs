using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Банк.MainDisplay;

namespace Банк
{
    public partial class openAccount : Form
    {
        public openAccount()
        {
            InitializeComponent();
        }

        public class Account
        {
            public int id;
            public string name;
            public double deposit_percentage;
            public string contribution;
            public string write_off;

            public Account(int id, string name, double deposit_percentage, string contribution, string write_off)
            {
                this.id = id;
                this.name = name;
                this.deposit_percentage = deposit_percentage;
                this.contribution = contribution;
                this.write_off = write_off;
            }
        }

        SqlConnection connect = new SqlConnection(Global.database);
        List<Account> account_list = new List<Account>();

        Color[] colors = { Color.LightGreen, Color.Khaki, Color.LightBlue, Color.Plum, Color.Pink, Color.PeachPuff };
        int color = 0;

        private void openAccount_Load(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "select * from deposits where interest_dep is null;";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Account account = new(
                                    int.Parse(reader["id_deposit"].ToString()),
                                    reader["name_deposit_default"].ToString(),
                                    double.Parse(reader["deposit_percentange"].ToString()),
                                    reader["contribution"].ToString(),
                                    reader["write_off"].ToString()
                                );
                                account_list.Add(account);
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

            for (int i = 0; i < account_list.Count; i++)
            {
                FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel()
                {
                    Name = $"flow{i}",
                    BackColor = colors[color],
                    AutoSize = true,
                    Margin = new Padding(0, 0, 20, 20),
                    MaximumSize = new Size(255, 0),
                    MinimumSize = new Size(255, 255),
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
                    Text = account_list[i].name,
                    AutoSize = true,
                    Margin = new Padding(0, 0, 0, 20),
                    MaximumSize = new Size(215, 0),
                    MinimumSize = new Size(215, 0)
                };

                flowLayoutPanel1.Controls[$"flow{i}"].Controls.Add(name);

                string description = "Возможность пополнять: ";

                if (account_list[i].contribution == "True")
                {
                    description += "есть\n";
                }
                else
                {
                    description += "нет\n";
                }

                description += "Возможность снимать: ";

                if (account_list[i].write_off == "True")
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
                    MaximumSize = new Size(215, 0),
                    MinimumSize = new Size(215, 0)
                };

                flowLayoutPanel1.Controls[$"flow{i}"].Controls.Add(lblDescription);

                Button button = new Button()
                {
                    Name = $"button{i}",
                    Tag = account_list[i].id,
                    Font = new Font(new FontFamily("Century"), 12, FontStyle.Regular),
                    Text = "Оформить",
                    Margin = new Padding(0, 0, 0, 0),
                    Size = new Size(130, 45),
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 },
                    BackColor = Color.WhiteSmoke,
                };

                flowLayoutPanel1.Controls[$"flow{i}"].Controls.Add(button);
                flowLayoutPanel1.Controls[$"flow{i}"].Controls[$"button{i}"].Click += OpenAccount_Click;
            }
        }

        private void OpenAccount_Click(object sender, EventArgs e)
        {
            Global.openAccount = int.Parse(((Button)sender).Tag.ToString());
            acceptOpenAccount acceptOpenAccount = new acceptOpenAccount();
            acceptOpenAccount.Show();
        }
    }
}
