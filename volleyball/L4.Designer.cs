﻿namespace volleyball
{
    partial class L4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(L4));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label2 = new Label();
            label1 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(931, 960);
            label2.TabIndex = 3;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(448, 13);
            label1.Name = "label1";
            label1.Size = new Size(157, 50);
            label1.TabIndex = 2;
            label1.Text = "УРОК 4";
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.Gold;
            guna2Button1.Location = new Point(12, 13);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(225, 56);
            guna2Button1.TabIndex = 4;
            guna2Button1.Text = "ПРОЙТИ ТЕСТ";
            // 
            // L4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 69, 69);
            ClientSize = new Size(1059, 450);
            Controls.Add(guna2Button1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "L4";
            Text = "L4";
            Load += L4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}