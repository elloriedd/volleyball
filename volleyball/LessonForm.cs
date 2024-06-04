using MySql.Data.MySqlClient;
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
    public partial class LessonForm : Form
    {
        public LessonForm()
        {
            InitializeComponent();
        }

        private void LessonForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            L1 l1 = new L1();
            l1.Show();
            this.Hide();
            StreamReader sr = new StreamReader("user.txt");
            string line;
            line = sr.ReadLine();
            int i = 0;
            DB db = new DB();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();


            MySqlCommand cmd = new MySqlCommand($"UPDATE `users` SET `progress` =1 WHERE login = '{line}'", db.getConnection());
            adapter.SelectCommand = cmd;
            adapter.Fill(table);





        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            L2 l2 = new L2();
            l2.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            L3 l3 = new L3();
            l3.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            L4 l4 = new L4();
            l4.Show();
            this.Hide();
        }
    }
}
