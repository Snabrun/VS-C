namespace Teht_9_10
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.muunnaBT = new System.Windows.Forms.Button();
            this.fahRB = new System.Windows.Forms.RadioButton();
            this.celRB = new System.Windows.Forms.RadioButton();
            this.vastausLB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna asteet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Miten muunnat?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // muunnaBT
            // 
            this.muunnaBT.Location = new System.Drawing.Point(419, 35);
            this.muunnaBT.Name = "muunnaBT";
            this.muunnaBT.Size = new System.Drawing.Size(75, 23);
            this.muunnaBT.TabIndex = 3;
            this.muunnaBT.Text = "Muunna";
            this.muunnaBT.UseVisualStyleBackColor = true;
            this.muunnaBT.Click += new System.EventHandler(this.muunnaBT_Click);
            // 
            // fahRB
            // 
            this.fahRB.AutoSize = true;
            this.fahRB.Location = new System.Drawing.Point(3, 52);
            this.fahRB.Name = "fahRB";
            this.fahRB.Size = new System.Drawing.Size(81, 19);
            this.fahRB.TabIndex = 4;
            this.fahRB.TabStop = true;
            this.fahRB.Text = "Fahrenheit";
            this.fahRB.UseVisualStyleBackColor = true;
            // 
            // celRB
            // 
            this.celRB.AutoSize = true;
            this.celRB.Location = new System.Drawing.Point(3, 27);
            this.celRB.Name = "celRB";
            this.celRB.Size = new System.Drawing.Size(62, 19);
            this.celRB.TabIndex = 5;
            this.celRB.TabStop = true;
            this.celRB.Text = "Celsius";
            this.celRB.UseVisualStyleBackColor = true;
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(30, 72);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(46, 15);
            this.vastausLB.TabIndex = 6;
            this.vastausLB.Text = "Vastaus";
            this.vastausLB.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.celRB);
            this.panel1.Controls.Add(this.fahRB);
            this.panel1.Location = new System.Drawing.Point(304, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 75);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 109);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.muunnaBT);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button muunnaBT;
        private RadioButton fahRB;
        private RadioButton celRB;
        private Label vastausLB;
        private Panel panel1;
    }
}