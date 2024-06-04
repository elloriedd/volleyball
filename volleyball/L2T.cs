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
    public partial class L2T : Form
    {


        public L2T()
        {
            InitializeComponent();
        }



        private void L1T_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true &&
                radioButton6.Checked == true &&
                radioButton8.Checked == true &&
                radioButton12.Checked == true)
            {

                MessageBox.Show("Тест пройден!");
                LessonForm lform = new LessonForm();
                lform.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Тест не пройден!");
                LessonForm lform = new LessonForm();
                lform.Show();
                this.Hide();
            }
        }
    }
}
