using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using MySql.Data.MySqlClient;
using Microsoft.SqlServer.Management.Smo;

namespace volleyball
{
    public partial class autorization : Form
    {
       
        public autorization()
        {
            InitializeComponent();

            
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
           
            if (guna2TextBox1.Text == "" ) {
                MessageBox.Show("Введите логин");
                return;
            }

            DB db = new DB();
            MySqlCommand cmnd = new MySqlCommand("INSERT INTO `login` (`login`, `pass`) VALUES (@login, @pass);", db.getConnection());
            cmnd.Parameters.Add("@login", MySqlDbType.VarChar).Value = guna2TextBox1.Text;
            cmnd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = guna2TextBox2.Text;

            db.openConnection();

            if (cmnd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("аккаунт создан");
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
            db.closeConnection();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            var loginUser = guna2TextBox6.Text;
            var passUser = guna2TextBox5.Text;

            DB db = new DB();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `login` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            cmd.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            cmd.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Добро пожаловать!");

            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }


        }

        private void iconButton10_Click(object sender, EventArgs e)
        {

            application form2 = new application();

            form2.Show();

            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox2.Checked)
            {
                guna2TextBox5.UseSystemPasswordChar = false;
            }
            else
            {
                guna2TextBox5.UseSystemPasswordChar = true;
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                guna2TextBox2.UseSystemPasswordChar = false;
                guna2TextBox3.UseSystemPasswordChar = false;
            }
            else
            {
                guna2TextBox2.UseSystemPasswordChar = true;
                guna2TextBox3.UseSystemPasswordChar = true;
            }
        }
    }
}
