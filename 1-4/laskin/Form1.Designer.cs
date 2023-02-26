namespace laskin
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
            this.Luku1TB = new System.Windows.Forms.TextBox();
            this.Luku2TB = new System.Windows.Forms.TextBox();
            this.LaskuCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Luku1TB
            // 
            this.Luku1TB.Location = new System.Drawing.Point(8, 12);
            this.Luku1TB.Name = "Luku1TB";
            this.Luku1TB.Size = new System.Drawing.Size(100, 23);
            this.Luku1TB.TabIndex = 0;
            this.Luku1TB.TextChanged += new System.EventHandler(this.Luku1TB_TextChanged);
            // 
            // Luku2TB
            // 
            this.Luku2TB.Location = new System.Drawing.Point(241, 12);
            this.Luku2TB.Name = "Luku2TB";
            this.Luku2TB.Size = new System.Drawing.Size(100, 23);
            this.Luku2TB.TabIndex = 1;
            // 
            // LaskuCB
            // 
            this.LaskuCB.FormattingEnabled = true;
            this.LaskuCB.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.LaskuCB.Location = new System.Drawing.Point(114, 12);
            this.LaskuCB.Name = "LaskuCB";
            this.LaskuCB.Size = new System.Drawing.Size(121, 23);
            this.LaskuCB.TabIndex = 2;
            this.LaskuCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(368, 20);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(14, 15);
            this.VastausLB.TabIndex = 5;
            this.VastausLB.Text = "X";
            this.VastausLB.Visible = false;
            this.VastausLB.Click += new System.EventHandler(this.Vastaus_Click);
            // 
            // LaskeBT
            // 
            this.LaskeBT.Location = new System.Drawing.Point(399, 12);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(75, 23);
            this.LaskeBT.TabIndex = 6;
            this.LaskeBT.Text = "Laske";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 51);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LaskuCB);
            this.Controls.Add(this.Luku2TB);
            this.Controls.Add(this.Luku1TB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Luku1TB;
        private TextBox Luku2TB;
        private ComboBox LaskuCB;
        private Label label1;
        private Label VastausLB;
        private Button LaskeBT;
    }
}