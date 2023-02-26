namespace WinFormsApp2
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
            this.otsikkoLB = new System.Windows.Forms.Label();
            this.ViestiTB = new System.Windows.Forms.TextBox();
            this.tulostavaBT = new System.Windows.Forms.Button();
            this.tulostusLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // otsikkoLB
            // 
            this.otsikkoLB.AutoSize = true;
            this.otsikkoLB.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.otsikkoLB.Location = new System.Drawing.Point(79, 55);
            this.otsikkoLB.Name = "otsikkoLB";
            this.otsikkoLB.Size = new System.Drawing.Size(225, 27);
            this.otsikkoLB.TabIndex = 0;
            this.otsikkoLB.Text = "Anna tulostettava teksti:";
            // 
            // ViestiTB
            // 
            this.ViestiTB.Font = new System.Drawing.Font("Stylus BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViestiTB.Location = new System.Drawing.Point(310, 52);
            this.ViestiTB.Name = "ViestiTB";
            this.ViestiTB.Size = new System.Drawing.Size(407, 33);
            this.ViestiTB.TabIndex = 1;
            // 
            // tulostavaBT
            // 
            this.tulostavaBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tulostavaBT.Location = new System.Drawing.Point(79, 93);
            this.tulostavaBT.Name = "tulostavaBT";
            this.tulostavaBT.Size = new System.Drawing.Size(75, 23);
            this.tulostavaBT.TabIndex = 2;
            this.tulostavaBT.Text = "Tulosta teksti";
            this.tulostavaBT.UseVisualStyleBackColor = true;
            this.tulostavaBT.Click += new System.EventHandler(this.tulostavaBT_Click);
            // 
            // tulostusLB
            // 
            this.tulostusLB.AutoSize = true;
            this.tulostusLB.Location = new System.Drawing.Point(79, 175);
            this.tulostusLB.Name = "tulostusLB";
            this.tulostusLB.Size = new System.Drawing.Size(31, 15);
            this.tulostusLB.TabIndex = 3;
            this.tulostusLB.Text = "xxxx";
            this.tulostusLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tulostusLB);
            this.Controls.Add(this.tulostavaBT);
            this.Controls.Add(this.ViestiTB);
            this.Controls.Add(this.otsikkoLB);
            this.ForeColor = System.Drawing.Color.MintCream;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label otsikkoLB;
        private TextBox ViestiTB;
        private Button tulostavaBT;
        private Label tulostusLB;
    }
}