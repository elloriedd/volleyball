﻿using MySql.Data.MySqlClient;
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
                StreamReader sr = new StreamReader("user.txt");
                string line;
                line = sr.ReadLine();
                int i = 0;
                DB db = new DB();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();


                MySqlCommand cmd = new MySqlCommand($"UPDATE `users` SET `progress` =2 WHERE login = '{line}'", db.getConnection());
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
