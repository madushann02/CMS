using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Madu
{
    public partial class CustomerDashboard : Form
    {
        private string username;
        public CustomerDashboard(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            label2.Text = "Mr." + username;
            showScreen(new OrderCab(username));
        }

        public void showScreen(object Form)
        {
            if (this.panel2.Controls.Count > 0)
            {
                this.panel2.Controls.RemoveAt(0);
            }
            Form frm = Form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(frm);
            this.panel2.Tag = frm;
            frm.Show();
        }
    }
}
