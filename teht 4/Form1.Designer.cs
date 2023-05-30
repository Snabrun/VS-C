namespace teht_4
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.laskeButton = new System.Windows.Forms.Button();
            this.vuosLB = new System.Windows.Forms.Label();
            this.kuuLB = new System.Windows.Forms.Label();
            this.paLB = new System.Windows.Forms.Label();
            this.tunLB = new System.Windows.Forms.Label();
            this.minLB = new System.Windows.Forms.Label();
            this.sekLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // laskeButton
            // 
            this.laskeButton.Location = new System.Drawing.Point(274, 34);
            this.laskeButton.Name = "laskeButton";
            this.laskeButton.Size = new System.Drawing.Size(75, 25);
            this.laskeButton.TabIndex = 1;
            this.laskeButton.Text = "Laske";
            this.laskeButton.UseVisualStyleBackColor = true;
            this.laskeButton.Click += new System.EventHandler(this.laskeButton_Click);
            // 
            // vuosLB
            // 
            this.vuosLB.AutoSize = true;
            this.vuosLB.Location = new System.Drawing.Point(46, 93);
            this.vuosLB.Name = "vuosLB";
            this.vuosLB.Size = new System.Drawing.Size(38, 15);
            this.vuosLB.TabIndex = 2;
            this.vuosLB.Text = "label1";
            this.vuosLB.Visible = false;
            // 
            // kuuLB
            // 
            this.kuuLB.AutoSize = true;
            this.kuuLB.Location = new System.Drawing.Point(46, 117);
            this.kuuLB.Name = "kuuLB";
            this.kuuLB.Size = new System.Drawing.Size(38, 15);
            this.kuuLB.TabIndex = 3;
            this.kuuLB.Text = "label2";
            this.kuuLB.Visible = false;
            // 
            // paLB
            // 
            this.paLB.AutoSize = true;
            this.paLB.Location = new System.Drawing.Point(46, 141);
            this.paLB.Name = "paLB";
            this.paLB.Size = new System.Drawing.Size(38, 15);
            this.paLB.TabIndex = 4;
            this.paLB.Text = "label3";
            this.paLB.Visible = false;
            // 
            // tunLB
            // 
            this.tunLB.AutoSize = true;
            this.tunLB.Location = new System.Drawing.Point(217, 93);
            this.tunLB.Name = "tunLB";
            this.tunLB.Size = new System.Drawing.Size(38, 15);
            this.tunLB.TabIndex = 5;
            this.tunLB.Text = "label4";
            this.tunLB.Visible = false;
            // 
            // minLB
            // 
            this.minLB.AutoSize = true;
            this.minLB.Location = new System.Drawing.Point(217, 117);
            this.minLB.Name = "minLB";
            this.minLB.Size = new System.Drawing.Size(38, 15);
            this.minLB.TabIndex = 6;
            this.minLB.Text = "label5";
            this.minLB.Visible = false;
            // 
            // sekLB
            // 
            this.sekLB.AutoSize = true;
            this.sekLB.Location = new System.Drawing.Point(217, 141);
            this.sekLB.Name = "sekLB";
            this.sekLB.Size = new System.Drawing.Size(38, 15);
            this.sekLB.TabIndex = 7;
            this.sekLB.Text = "label6";
            this.sekLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 232);
            this.Controls.Add(this.sekLB);
            this.Controls.Add(this.minLB);
            this.Controls.Add(this.tunLB);
            this.Controls.Add(this.paLB);
            this.Controls.Add(this.kuuLB);
            this.Controls.Add(this.vuosLB);
            this.Controls.Add(this.laskeButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Ikalaskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button laskeButton;
        private Label vuosLB;
        private Label kuuLB;
        private Label paLB;
        private Label tunLB;
        private Label minLB;
        private Label sekLB;
    }
}