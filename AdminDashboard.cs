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
    public partial class AdminDashboard : Form
    {
        public void showScreen(object Form)
        {
            if (this.panel3.Controls.Count > 0)
            {
                this.panel3.Controls.RemoveAt(0);
            }
            Form frm = Form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(frm);
            this.panel3.Tag = frm;
            frm.Show();
        }
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showScreen(new ViewOrders());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showScreen(new CarManagment());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showScreen(new DriverManagment());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Logout().Show();
        }
    }
}
