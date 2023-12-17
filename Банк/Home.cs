using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Банк.MainDisplay;

namespace Банк
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void currentTime_Tick(object sender, EventArgs e)
        {
            var time = DateTime.Now.ToString("HH:mm:ss");
            lblCurrentTime.Text = time;
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

        private void lblAddCustomer_Click(object sender, EventArgs e)
        {
            LoadForm(new FormAddCustomer());
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.Silver;
            Cursor = Cursors.Hand;
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.White;
            Cursor = Cursors.Default;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            currentTime.Start();
        }

        private void lblFindCustomer_Click(object sender, EventArgs e)
        {
            LoadForm(new FindCustomer());
        }
    }
}
