using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volleyball
{
    public partial class L4 : Form
    {
        public L4()
        {
            InitializeComponent();
        }

        private void L4_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            L4T l4T = new L4T();
            l4T.Show();
            this.Hide();
        }
    }
}
