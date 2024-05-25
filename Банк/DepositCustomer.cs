using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Банк.MainDisplay;

namespace Банк
{
    public partial class DepositCustomer : Form
    {
        SqlConnection connect = new SqlConnection(Global.database);

        public DepositCustomer()
        {
            InitializeComponent();
        }

        private void DepositCustomer_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            label1.Visible = false;

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string checkCustomerPassport = "select count(passport_customer) from customersDeposits, customers, deposits where customersDeposits.customer_id = customers.id_customer and deposits.id_deposit = customersDeposits.deposit_id and deposit_percentange <> 0 and passport_customer = @passport_customer";

                    using (SqlCommand checkCust = new SqlCommand(checkCustomerPassport, connect))
                    {
                        checkCust.Parameters.AddWithValue("@passport_customer", Number.passport_customer);
                        int count = (int)checkCust.ExecuteScalar();

                        if (count == 0)
                        {
                            label1.Visible = true;
                        }
                        else
                        {
                            dataGridView1.Visible = true;

                            string selectData = "select id_customer_deposit, name_deposit as Вклад, bank_account as 'Номер счета', deposit_date as 'Дата вклада', return_deposit_date as 'Дата окончания вклада', deposit_amount as 'Сумма вклада', status_dep as 'Статус' from customersDeposits, customers, deposits where customers.id_customer = customersDeposits.customer_id and deposits.id_deposit = customersDeposits.deposit_id and passport_customer = @passport_customer and deposits.deposit_percentange <> 0";

                            using (SqlCommand cmd = new SqlCommand(selectData, connect))
                            {
                                cmd.Parameters.AddWithValue("@passport_customer", Number.passport_customer);

                                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                                DataTable table = new DataTable();
                                adapter.Fill(table);

                                dataGridView1.DataSource = table;
                                dataGridView1.Columns[0].Visible = false;
                                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[3].Visible = false;
                                dataGridView1.Columns[4].Visible = false;
                                dataGridView1.Columns[6].Visible = false;
                                dataGridView1.Columns[4].ValueType = typeof(SqlMoney);
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Global.deposit = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            LoadForm(new Deposit());
        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Width > 720)
            {
                dataGridView1.Columns[3].Visible = true;
                dataGridView1.Columns[4].Visible = true;
                dataGridView1.Columns[6].Visible = true;
            }
            if (dataGridView1.Width <= 720 && dataGridView1.DataSource != null)
            {
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[6].Visible = false;
            }
        }
    }
}
