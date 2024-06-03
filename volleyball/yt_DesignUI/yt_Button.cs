using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Windows.Forms;
using System.ComponentModel;

namespace volleyball
{
    public class yt_Button : Control
    {

        private bool roundingEnable = false;
        [Description("Вкл/Выкл закругление объекта")]
        public bool RoundingEnable
        {
            get => roundingEnable;
            set
            {
                roundingEnable = value;
                Refresh();
            }
        }

        private int roundingPercent = 100;
        [DisplayName("Rounding [%]")]
        [DefaultValue(100)]
        [Description("Указывает радиус закругления объекта в процентном соотношении")]
        public int Rounding
        {
            get => roundingPercent;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    roundingPercent = value;

                    Refresh();
                }
            }
        }


        private StringFormat SF = new StringFormat();

        private bool MouseEntered = false;
        private bool MousePressed = false;

        Animation RippleButtonAnim = new Animation();

        Point ClickLocation = new Point();


        public yt_Button()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor |
                ControlStyles.UserPaint |
                ControlStyles.Opaque |
                ControlStyles.Selectable |
                ControlStyles.UserMouse |
                ControlStyles.EnableNotifyMessage,
                true);

            DoubleBuffered = true;

            Size = new Size(100, 30);

            BackColor = Color.Tomato;
            ForeColor = Color.White;

            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;


            graph.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle rectRipple = new Rectangle(
                ClickLocation.X - (int)RippleButtonAnim.Value / 2,
                ClickLocation.Y - (int)RippleButtonAnim.Value / 2,
                (int)RippleButtonAnim.Value,
               (int)RippleButtonAnim.Value
                );

            float roundingValue = 0.1F;
            if (RoundingEnable && roundingPercent > 0)
            {
                roundingValue = Height / 100F * roundingPercent;
            }
            GraphicsPath rectPath = Drawer.RoundedRectangle(rect, roundingValue);

            graph.DrawPath(new Pen(BackColor), rectPath);
            graph.FillPath(new SolidBrush(BackColor), rectPath);

            graph.SetClip(rectPath);

            if (MouseEntered)
            {
                graph.DrawRectangle(new Pen(Color.FromArgb(60, Color.White)), rect);
                graph.FillRectangle(new SolidBrush(Color.FromArgb(60, Color.White)), rect);
            }

            //if (MousePressed)
            // {
            //    graph.DrawRectangle(new Pen(Color.FromArgb(60, Color.Black)), rect);
            //    graph.FillRectangle(new SolidBrush(Color.FromArgb(60, Color.Black)), rect);
            //  }

            if (RippleButtonAnim.Value > 0 && RippleButtonAnim.Value < RippleButtonAnim.TargetValue)
            {
                graph.DrawEllipse(new Pen(Color.FromArgb(150, Color.Red)), rectRipple);
                graph.FillEllipse(new SolidBrush(Color.FromArgb(150, Color.Red)), rectRipple);
            }
            else if (RippleButtonAnim.Value == RippleButtonAnim.TargetValue)
            {
                RippleButtonAnim.Value = 0;
            }

            graph.DrawString(Text, Font, new SolidBrush(ForeColor), rect, SF);

        }

        private void ButtonRippleAction()
        {
            RippleButtonAnim = new Animation("ButtonRipple_" + Handle, Invalidate, 0, Width * 2);
            Animator.Request(RippleButtonAnim, true);
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            MouseEntered = true;

            Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            MouseEntered = false;

            Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            MousePressed = true;

            ClickLocation = e.Location;

            ButtonRippleAction();

            // Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            MousePressed = false;

            Invalidate();
        }
    }
}