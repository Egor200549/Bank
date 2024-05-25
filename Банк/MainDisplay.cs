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

namespace Банк
{
    public partial class MainDisplay : Form
    {
        public static class Global
        {
            public static Panel pn {  get; set; }
            public static Panel pnDeposit { get; set; }
            public static int employee_account { get; set; }

            public static string database = "Data Source=ACER-NITRO-5-49\\SQLEXPRESS;Initial Catalog=bank;Integrated Security=True";
            public static int deposit { get; set; }
            public static string code { get; set; }
            public static Button btn { get; set; }

            //открытие вклада

            public static int openDeposit { get; set; }
            public static double openDepositSum { get; set; }
            public static int openDepositPeriod { get; set; }
            public static int accountFrom {  get; set; }
            public static bool openDepositAccept {  get; set; }
        }

        public static class Number
        {
            public static string passport_customer { get; set; }
        }
        

        public MainDisplay()
        {
            InitializeComponent();
        }

        private void MainDisplay_Load(object sender, EventArgs e)
        {
            LoadForm(new Home());
            Global.pn = pnMain;
            MainDisplay mainDisplay = new MainDisplay();
        }

        private void MainDisplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        bool sidebarExpand;

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panel.Width -= 5;
                if (panel.Width == panel.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                panel.Width += 5;
                if (panel.Width == panel.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadForm(new Home());
        }

        private void LoadForm (object Form)
        {
            if (pnMain.Controls.Count > 0)
                pnMain.Controls.RemoveAt(0);
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnMain.Controls.Add(form);
            pnMain.Tag = form;
            form.Show();
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.Silver;
            Cursor = Cursors.Hand;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.White;
            Cursor = Cursors.Default;
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadForm(new Home());
        }
    }
}
