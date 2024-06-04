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
    public partial class UserForm : Form
    {

        private string textBox1Value;
        private string textBox2Value;
        private string textBox3Value;


        public UserForm()
        {
            InitializeComponent();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            // Сохраняем значения текстбоксов в переменные класса
            textBox1Value = guna2TextBox1.Text;
            textBox2Value = guna2TextBox2.Text;
            textBox3Value = guna2TextBox3.Text;

            // Опционально: вы можете добавить здесь код для сохранения переменных, например, в базу данных или файл.
        }



        private void guna2GroupBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void text_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {

            guna2ProgressBar1.Value += 4; // Например, увеличим на 10

            // Проверяем, не превысило ли значение прогресс-бара его максимальное значение
            if (guna2ProgressBar1.Value > guna2ProgressBar1.Maximum)
            {
                // Если превысило, устанавливаем значение прогресс-бара равным его максимальному значению
                guna2ProgressBar1.Value = guna2ProgressBar1.Maximum;
            }
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            LessonForm lform = new LessonForm();
            lform.Show();

        }
    }
}
