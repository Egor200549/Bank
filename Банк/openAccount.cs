using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
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

        class Deposit
        {
            int id;
            string name;
            int currency_code;
            double deposit_percentage;
            string contribution;
            string write_off;
            string interest_dep;

            public Deposit(int id, string name, int currency_code, double deposit_percentage, string contribution, string write_off,
                string interest_dep)
            {
                this.id = id;
                this.name = name;
                this.currency_code = currency_code;
                this.deposit_percentage = deposit_percentage;
                this.contribution = contribution;
                this.write_off = write_off;
                this.interest_dep = interest_dep;
            }
        }

        SqlConnection connect = new SqlConnection(Global.database);
        List<Deposit> deposit_list = new List<Deposit>();

        Color[] colors = { Color.LightGreen, Color.Khaki, Color.LightBlue, Color.Plum, Color.Pink };
        int color = 0;

        private void openAccount_Load(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "select * from deposits;";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Deposit deposit = new (
                                    int.Parse(reader["id_deposit"].ToString()),
                                    reader["name_deposit_default"].ToString(),
                                    int.Parse(reader["currency_code"].ToString()),
                                    double.Parse(reader["deposit_percentange"].ToString()),
                                    reader["contribution"].ToString(),
                                    reader["write_off"].ToString(),
                                    reader["interest_dep"].ToString()
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
                    Name = "flowLayoutPanel" + i.ToString(),
                    BackColor = colors[color],
                    AutoSize = true,
                    Margin = new Padding(0, 0, 20, 20),
                    MaximumSize =  new Size(295, 0),
                    MinimumSize = new Size(0 ,295),
                    Padding = new Padding(20),
                };

                color++;

                if (color > colors.Length - 1)
                {
                    color = 0;
                }

                flowLayoutPanel1.Controls.Add(flowLayoutPanel);

                System.Windows.Forms.Label label = new System.Windows.Forms.Label()
                {
                    Name = "label" + i.ToString(),
                    Font = new Font(new FontFamily("Century"), 14, FontStyle.Bold)
                };

                FlowLayoutPanel current_flow = Controls["flowLayoutPanel" + i];
                current_flow.Controls.Add(label);
            }
        }
    }
}
