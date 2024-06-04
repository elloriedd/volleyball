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
    public partial class L3T : Form
    {
        public L3T()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true &&
                radioButton5.Checked == true &&
                radioButton9.Checked == true &&
                radioButton10.Checked == true)
            {

                MessageBox.Show("Тест пройден!");
                StreamReader sr = new StreamReader("user.txt");
                string line;
                line = sr.ReadLine();
                DB db = new DB();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();


                MySqlCommand cmd = new MySqlCommand($"UPDATE `users` SET `progress` =3 WHERE login = '{line}'", db.getConnection());
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
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
