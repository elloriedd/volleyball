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
    public partial class L2 : Form
    {
        public L2()
        {
            InitializeComponent();
        }

        private void L2_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            L2T test1 = new L2T();
            test1.Show();
            this.Hide();
        }
    }
}
