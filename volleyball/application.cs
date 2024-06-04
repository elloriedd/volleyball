using FontAwesome.Sharp;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Helpers.GraphicsHelper;
using static System.Windows.Forms.DataFormats;
using MySql.Data.MySqlClient;
using System.Data;
using Guna.UI2.WinForms;

namespace volleyball
{
    public partial class application : Form
    {
        public application()
        {

            InitializeComponent();
            

        }

        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;

        private Color activeBackgroundColor = Color.FromArgb(100, 100, 100);
        private Color activeForegroundColor = Color.Gold;

        private Color defaultBackgroundColor = Color.FromArgb(69, 69, 69);
        private Color defaultForegroundColor = Color.FromArgb(255, 255, 255);


        private Form acriveForm = null;
        private void openForm(Form childForm)
        {

           

            if (acriveForm != null)
                acriveForm.Close();
            acriveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel5.Controls.Add(childForm);
            panel5.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();



        }

        private void SetButtonColors(IconButton button, Color backColor, Color foreColor)
        {
            button.BackColor = backColor;
            button.ForeColor = foreColor;
            button.IconColor = foreColor;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            IconButton activeButton = (IconButton)sender;
            SetButtonColors(activeButton, activeBackgroundColor, activeForegroundColor);

            leftpanel1.Visible = true;

            SetButtonColors(iconButton3, defaultBackgroundColor, defaultForegroundColor);
            SetButtonColors(iconButton5, defaultBackgroundColor, defaultForegroundColor);


            leftpanel2.Visible = false;
            leftpanel3.Visible = false;


            openForm(new MainForm1());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            IconButton activeButton = (IconButton)sender;
            SetButtonColors(activeButton, activeBackgroundColor, activeForegroundColor);

            leftpanel2.Visible = true;

            SetButtonColors(iconButton2, defaultBackgroundColor, defaultForegroundColor);
            SetButtonColors(iconButton5, defaultBackgroundColor, defaultForegroundColor);


            leftpanel1.Visible = false;
            leftpanel3.Visible = false;


            openForm(new UserForm());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            IconButton activeButton = (IconButton)sender;
            SetButtonColors(activeButton, activeBackgroundColor, activeForegroundColor);

            leftpanel3.Visible = true;

            SetButtonColors(iconButton3, defaultBackgroundColor, defaultForegroundColor);
            SetButtonColors(iconButton2, defaultBackgroundColor, defaultForegroundColor);


            leftpanel2.Visible = false;
            leftpanel1.Visible = false;
            LessonForm lform = new LessonForm();
            lform.Show();

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            IconButton activeButton = (IconButton)sender;
            SetButtonColors(activeButton, activeBackgroundColor, activeForegroundColor);



            SetButtonColors(iconButton3, defaultBackgroundColor, defaultForegroundColor);
            SetButtonColors(iconButton5, defaultBackgroundColor, defaultForegroundColor);
            SetButtonColors(iconButton2, defaultBackgroundColor, defaultForegroundColor);

            leftpanel2.Visible = false;
            leftpanel3.Visible = false;
            leftpanel1.Visible = false;
        }


        private void yt_Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void iconButton11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton9_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void iconButton11_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            autorization form1 = new autorization();

            form1.Show();

            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        // Пример метода для изменения изображения 2 в зависимости от изображения 1
        private Image ProcessImage(Image image)
        {
            // Здесь можно написать логику, которая определяет, какое изображение установить в зависимости от изображения 1
            // Например, можно изменить размер, преобразовать цвета и т.д.
            // В данном примере просто возвращаем тоже самое изображение
            return image;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            autorization form1 = new autorization();
            this.label2.Text = form1.login;
        }

       
    }
}
