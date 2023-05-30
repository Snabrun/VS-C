namespace Teht_13_14
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
            this.nimiTB = new System.Windows.Forms.TextBox();
            this.tarkistaBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.vastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nimiTB
            // 
            this.nimiTB.Location = new System.Drawing.Point(386, 42);
            this.nimiTB.Name = "nimiTB";
            this.nimiTB.Size = new System.Drawing.Size(100, 23);
            this.nimiTB.TabIndex = 0;
            // 
            // tarkistaBT
            // 
            this.tarkistaBT.Location = new System.Drawing.Point(501, 41);
            this.tarkistaBT.Name = "tarkistaBT";
            this.tarkistaBT.Size = new System.Drawing.Size(75, 23);
            this.tarkistaBT.TabIndex = 1;
            this.tarkistaBT.Text = "Tarkista";
            this.tarkistaBT.UseVisualStyleBackColor = true;
            this.tarkistaBT.Click += new System.EventHandler(this.tarkistaBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Anna nimesi, niin tarkastan, onko se 50 suosituimman joukossa:";
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(37, 101);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(38, 15);
            this.vastausLB.TabIndex = 3;
            this.vastausLB.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 189);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tarkistaBT);
            this.Controls.Add(this.nimiTB);
            this.Name = "Form1";
            this.Text = "Onko nimesi suosittujen joukossa?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nimiTB;
        private Button tarkistaBT;
        private Label label1;
        private Label vastausLB;
    }
}