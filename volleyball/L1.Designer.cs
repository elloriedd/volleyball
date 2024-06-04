namespace volleyball
{
    partial class L1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(L1));
            label1 = new Label();
            label2 = new Label();
            iconButton10 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(408, 19);
            label1.Name = "label1";
            label1.Size = new Size(152, 50);
            label1.TabIndex = 0;
            label1.Text = "УРОК 1";
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(913, 1160);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // iconButton10
            // 
            iconButton10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton10.BackColor = Color.FromArgb(255, 128, 0);
            iconButton10.Cursor = Cursors.Hand;
            iconButton10.FlatAppearance.BorderSize = 0;
            iconButton10.FlatStyle = FlatStyle.Flat;
            iconButton10.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            iconButton10.IconColor = Color.White;
            iconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton10.IconSize = 30;
            iconButton10.Location = new Point(853, 19);
            iconButton10.Name = "iconButton10";
            iconButton10.Size = new Size(30, 32);
            iconButton10.TabIndex = 4;
            iconButton10.TextAlign = ContentAlignment.MiddleLeft;
            iconButton10.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton10.UseVisualStyleBackColor = false;
            iconButton10.Click += iconButton10_Click;
            // 
            // L1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(69, 69, 69);
            ClientSize = new Size(953, 676);
            ControlBox = false;
            Controls.Add(iconButton10);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "L1";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "L1";
            Load += L1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton10;
    }
}