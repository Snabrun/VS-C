namespace teht_5
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
            this.salasanaPL = new System.Windows.Forms.Panel();
            this.virheLB = new System.Windows.Forms.Label();
            this.tarkistaBT = new System.Windows.Forms.Button();
            this.salasanaTB = new System.Windows.Forms.TextBox();
            this.kayttajaTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tervetuloaPL = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.salasanaPL.SuspendLayout();
            this.tervetuloaPL.SuspendLayout();
            this.SuspendLayout();
            // 
            // salasanaPL
            // 
            this.salasanaPL.BackColor = System.Drawing.Color.MidnightBlue;
            this.salasanaPL.Controls.Add(this.virheLB);
            this.salasanaPL.Controls.Add(this.tarkistaBT);
            this.salasanaPL.Controls.Add(this.salasanaTB);
            this.salasanaPL.Controls.Add(this.kayttajaTB);
            this.salasanaPL.Controls.Add(this.label2);
            this.salasanaPL.Controls.Add(this.label1);
            this.salasanaPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salasanaPL.Location = new System.Drawing.Point(0, 0);
            this.salasanaPL.Margin = new System.Windows.Forms.Padding(6);
            this.salasanaPL.Name = "salasanaPL";
            this.salasanaPL.Size = new System.Drawing.Size(542, 238);
            this.salasanaPL.TabIndex = 0;
            this.salasanaPL.Paint += new System.Windows.Forms.PaintEventHandler(this.salasanaPL_Paint);
            // 
            // virheLB
            // 
            this.virheLB.AutoSize = true;
            this.virheLB.Location = new System.Drawing.Point(32, 191);
            this.virheLB.Name = "virheLB";
            this.virheLB.Size = new System.Drawing.Size(68, 31);
            this.virheLB.TabIndex = 5;
            this.virheLB.Text = "Virhe";
            this.virheLB.Visible = false;
            // 
            // tarkistaBT
            // 
            this.tarkistaBT.ForeColor = System.Drawing.Color.Black;
            this.tarkistaBT.Location = new System.Drawing.Point(32, 143);
            this.tarkistaBT.Name = "tarkistaBT";
            this.tarkistaBT.Size = new System.Drawing.Size(119, 35);
            this.tarkistaBT.TabIndex = 4;
            this.tarkistaBT.Text = "Tarkista";
            this.tarkistaBT.UseVisualStyleBackColor = true;
            this.tarkistaBT.Click += new System.EventHandler(this.tarkistaBT_Click);
            // 
            // salasanaTB
            // 
            this.salasanaTB.Location = new System.Drawing.Point(217, 87);
            this.salasanaTB.Name = "salasanaTB";
            this.salasanaTB.Size = new System.Drawing.Size(186, 38);
            this.salasanaTB.TabIndex = 3;
            // 
            // kayttajaTB
            // 
            this.kayttajaTB.Location = new System.Drawing.Point(217, 37);
            this.kayttajaTB.Name = "kayttajaTB";
            this.kayttajaTB.Size = new System.Drawing.Size(186, 38);
            this.kayttajaTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salasana:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Käyttäjätunnus:";
            // 
            // tervetuloaPL
            // 
            this.tervetuloaPL.BackColor = System.Drawing.Color.Maroon;
            this.tervetuloaPL.Controls.Add(this.label3);
            this.tervetuloaPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tervetuloaPL.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tervetuloaPL.ForeColor = System.Drawing.Color.Snow;
            this.tervetuloaPL.Location = new System.Drawing.Point(0, 0);
            this.tervetuloaPL.Name = "tervetuloaPL";
            this.tervetuloaPL.Size = new System.Drawing.Size(542, 238);
            this.tervetuloaPL.TabIndex = 1;
            this.tervetuloaPL.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-19, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(555, 80);
            this.label3.TabIndex = 0;
            this.label3.Text = "Terveruloa sivulleni";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 238);
            this.Controls.Add(this.tervetuloaPL);
            this.Controls.Add(this.salasanaPL);
            this.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Gold;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.salasanaPL.ResumeLayout(false);
            this.salasanaPL.PerformLayout();
            this.tervetuloaPL.ResumeLayout(false);
            this.tervetuloaPL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel salasanaPL;
        private Label virheLB;
        private Button tarkistaBT;
        private TextBox salasanaTB;
        private TextBox kayttajaTB;
        private Label label2;
        private Label label1;
        private Panel tervetuloaPL;
        private Label label3;
    }
}