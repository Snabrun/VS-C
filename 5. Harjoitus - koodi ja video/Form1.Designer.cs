﻿namespace _5._Harjoitus___koodi_ja_video
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.uusiLukuTB = new System.Windows.Forms.TextBox();
            this.vastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna luku (-999) lopetus";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // uusiLukuTB
            // 
            this.uusiLukuTB.Location = new System.Drawing.Point(165, 68);
            this.uusiLukuTB.Name = "uusiLukuTB";
            this.uusiLukuTB.Size = new System.Drawing.Size(100, 23);
            this.uusiLukuTB.TabIndex = 1;
            this.uusiLukuTB.Text = "0";
            this.uusiLukuTB.TextChanged += new System.EventHandler(this.uusiLukuTB_TextChanged);
            this.uusiLukuTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uusiLukuTB_KeyPress);
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(21, 124);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(38, 15);
            this.vastausLB.TabIndex = 2;
            this.vastausLB.Text = "label2";
            this.vastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 169);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.uusiLukuTB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox uusiLukuTB;
        private Label vastausLB;
    }
}