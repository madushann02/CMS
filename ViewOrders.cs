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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            dataGridView1.DataSource = admin.view_Orders();
        }
    }
}
