namespace Teht_12
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
            this.kysymysLB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dummyRB = new System.Windows.Forms.RadioButton();
            this.vastausARB = new System.Windows.Forms.RadioButton();
            this.vastausBRB = new System.Windows.Forms.RadioButton();
            this.vastausDRB = new System.Windows.Forms.RadioButton();
            this.vastausCRB = new System.Windows.Forms.RadioButton();
            this.VastausLB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kysymysLB
            // 
            this.kysymysLB.AutoSize = true;
            this.kysymysLB.Location = new System.Drawing.Point(27, 38);
            this.kysymysLB.Name = "kysymysLB";
            this.kysymysLB.Size = new System.Drawing.Size(134, 15);
            this.kysymysLB.TabIndex = 0;
            this.kysymysLB.Text = "Vastaus 1. kysymykseen:";
            this.kysymysLB.Click += new System.EventHandler(this.kysymysLB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vastausDRB);
            this.groupBox1.Controls.Add(this.vastausCRB);
            this.groupBox1.Controls.Add(this.vastausBRB);
            this.groupBox1.Controls.Add(this.vastausARB);
            this.groupBox1.Controls.Add(this.dummyRB);
            this.groupBox1.Location = new System.Drawing.Point(280, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(82, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dummyRB
            // 
            this.dummyRB.AutoCheck = false;
            this.dummyRB.AutoSize = true;
            this.dummyRB.Location = new System.Drawing.Point(13, 30);
            this.dummyRB.Name = "dummyRB";
            this.dummyRB.Size = new System.Drawing.Size(31, 19);
            this.dummyRB.TabIndex = 0;
            this.dummyRB.TabStop = true;
            this.dummyRB.Text = "E";
            this.dummyRB.UseVisualStyleBackColor = true;
            this.dummyRB.Visible = false;
            // 
            // vastausARB
            // 
            this.vastausARB.AutoSize = true;
            this.vastausARB.Location = new System.Drawing.Point(13, 21);
            this.vastausARB.Name = "vastausARB";
            this.vastausARB.Size = new System.Drawing.Size(33, 19);
            this.vastausARB.TabIndex = 1;
            this.vastausARB.TabStop = true;
            this.vastausARB.Text = "A";
            this.vastausARB.UseVisualStyleBackColor = true;
            // 
            // vastausBRB
            // 
            this.vastausBRB.AutoSize = true;
            this.vastausBRB.Location = new System.Drawing.Point(13, 46);
            this.vastausBRB.Name = "vastausBRB";
            this.vastausBRB.Size = new System.Drawing.Size(32, 19);
            this.vastausBRB.TabIndex = 2;
            this.vastausBRB.TabStop = true;
            this.vastausBRB.Text = "B";
            this.vastausBRB.UseVisualStyleBackColor = true;
            // 
            // vastausDRB
            // 
            this.vastausDRB.AutoSize = true;
            this.vastausDRB.Location = new System.Drawing.Point(13, 96);
            this.vastausDRB.Name = "vastausDRB";
            this.vastausDRB.Size = new System.Drawing.Size(33, 19);
            this.vastausDRB.TabIndex = 4;
            this.vastausDRB.TabStop = true;
            this.vastausDRB.Text = "D";
            this.vastausDRB.UseVisualStyleBackColor = true;
            // 
            // vastausCRB
            // 
            this.vastausCRB.AutoSize = true;
            this.vastausCRB.Location = new System.Drawing.Point(13, 71);
            this.vastausCRB.Name = "vastausCRB";
            this.vastausCRB.Size = new System.Drawing.Size(33, 19);
            this.vastausCRB.TabIndex = 3;
            this.vastausCRB.TabStop = true;
            this.vastausCRB.Text = "C";
            this.vastausCRB.UseVisualStyleBackColor = true;
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(27, 124);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(46, 15);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 167);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kysymysLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label kysymysLB;
        private GroupBox groupBox1;
        private RadioButton vastausDRB;
        private RadioButton vastausCRB;
        private RadioButton vastausBRB;
        private RadioButton vastausARB;
        private RadioButton dummyRB;
        private Label VastausLB;
    }
}