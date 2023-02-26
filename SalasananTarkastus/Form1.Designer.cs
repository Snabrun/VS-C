namespace SalasananTarkastus
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
            this.salasanaPanel = new System.Windows.Forms.Panel();
            this.salasanaOikeinP = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.virheviestiLB = new System.Windows.Forms.Label();
            this.tarkistaBT = new System.Windows.Forms.Button();
            this.salasanaTB = new System.Windows.Forms.TextBox();
            this.kauttajaTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.salasanaPanel.SuspendLayout();
            this.salasanaOikeinP.SuspendLayout();
            this.SuspendLayout();
            // 
            // salasanaPanel
            // 
            this.salasanaPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.salasanaPanel.Controls.Add(this.virheviestiLB);
            this.salasanaPanel.Controls.Add(this.tarkistaBT);
            this.salasanaPanel.Controls.Add(this.salasanaTB);
            this.salasanaPanel.Controls.Add(this.kauttajaTB);
            this.salasanaPanel.Controls.Add(this.label2);
            this.salasanaPanel.Controls.Add(this.label1);
            this.salasanaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salasanaPanel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salasanaPanel.ForeColor = System.Drawing.Color.Gold;
            this.salasanaPanel.Location = new System.Drawing.Point(0, 0);
            this.salasanaPanel.Name = "salasanaPanel";
            this.salasanaPanel.Size = new System.Drawing.Size(531, 218);
            this.salasanaPanel.TabIndex = 0;
            this.salasanaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.salasanaPanel_Paint);
            // 
            // salasanaOikeinP
            // 
            this.salasanaOikeinP.BackColor = System.Drawing.Color.Maroon;
            this.salasanaOikeinP.Controls.Add(this.label3);
            this.salasanaOikeinP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salasanaOikeinP.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salasanaOikeinP.ForeColor = System.Drawing.Color.Snow;
            this.salasanaOikeinP.Location = new System.Drawing.Point(0, 0);
            this.salasanaOikeinP.Name = "salasanaOikeinP";
            this.salasanaOikeinP.Size = new System.Drawing.Size(531, 218);
            this.salasanaOikeinP.TabIndex = 1;
            this.salasanaOikeinP.Visible = false;
            this.salasanaOikeinP.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(428, 65);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tervetuloa sivulleni";
            // 
            // virheviestiLB
            // 
            this.virheviestiLB.AutoSize = true;
            this.virheviestiLB.Location = new System.Drawing.Point(116, 107);
            this.virheviestiLB.Name = "virheviestiLB";
            this.virheviestiLB.Size = new System.Drawing.Size(70, 32);
            this.virheviestiLB.TabIndex = 5;
            this.virheviestiLB.Text = "Virhe";
            this.virheviestiLB.Visible = false;
            // 
            // tarkistaBT
            // 
            this.tarkistaBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tarkistaBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tarkistaBT.Location = new System.Drawing.Point(12, 104);
            this.tarkistaBT.Name = "tarkistaBT";
            this.tarkistaBT.Size = new System.Drawing.Size(95, 39);
            this.tarkistaBT.TabIndex = 4;
            this.tarkistaBT.Text = "Tarkista";
            this.tarkistaBT.UseVisualStyleBackColor = true;
            this.tarkistaBT.Click += new System.EventHandler(this.tarkistaBT_Click);
            // 
            // salasanaTB
            // 
            this.salasanaTB.Location = new System.Drawing.Point(190, 55);
            this.salasanaTB.Name = "salasanaTB";
            this.salasanaTB.Size = new System.Drawing.Size(100, 39);
            this.salasanaTB.TabIndex = 3;
            // 
            // kauttajaTB
            // 
            this.kauttajaTB.Location = new System.Drawing.Point(190, 6);
            this.kauttajaTB.Name = "kauttajaTB";
            this.kauttajaTB.Size = new System.Drawing.Size(100, 39);
            this.kauttajaTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salasana";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Käyttäjätunnus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 218);
            this.Controls.Add(this.salasanaOikeinP);
            this.Controls.Add(this.salasanaPanel);
            this.Name = "Form1";
            this.Text = "SalasanaForm";
            this.salasanaPanel.ResumeLayout(false);
            this.salasanaPanel.PerformLayout();
            this.salasanaOikeinP.ResumeLayout(false);
            this.salasanaOikeinP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel salasanaPanel;
        private Label virheviestiLB;
        private Button tarkistaBT;
        private TextBox salasanaTB;
        private TextBox kauttajaTB;
        private Label label2;
        private Label label1;
        private Panel salasanaOikeinP;
        private Label label3;
    }
}