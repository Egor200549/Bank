using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Банк.MainDisplay;

namespace Банк
{
    public partial class ConfirmationCode : Form
    {
        public ConfirmationCode()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == Global.code)
            {
                LoadForm(new CustomerAccount());
                this.Hide();
            }
            else
            {
                MessageBox.Show("Пароль неверный", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
