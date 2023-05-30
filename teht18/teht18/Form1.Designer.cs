namespace teht18
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
            this.oppilaitosCB = new System.Windows.Forms.ComboBox();
            this.vastuuhloCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.osLB = new System.Windows.Forms.Label();
            this.posNLB = new System.Windows.Forms.Label();
            this.posPLB = new System.Windows.Forms.Label();
            this.puhLB = new System.Windows.Forms.Label();
            this.titLB = new System.Windows.Forms.Label();
            this.osasLB = new System.Windows.Forms.Label();
            this.sahLB = new System.Windows.Forms.Label();
            this.puh2LB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oppilaitosten avainhenkilöt";
            // 
            // oppilaitosCB
            // 
            this.oppilaitosCB.FormattingEnabled = true;
            this.oppilaitosCB.Location = new System.Drawing.Point(30, 120);
            this.oppilaitosCB.Name = "oppilaitosCB";
            this.oppilaitosCB.Size = new System.Drawing.Size(121, 23);
            this.oppilaitosCB.TabIndex = 1;
            this.oppilaitosCB.SelectedIndexChanged += new System.EventHandler(this.oppilaitosCB_SelectedIndexChanged);
            // 
            // vastuuhloCB
            // 
            this.vastuuhloCB.FormattingEnabled = true;
            this.vastuuhloCB.Location = new System.Drawing.Point(226, 120);
            this.vastuuhloCB.Name = "vastuuhloCB";
            this.vastuuhloCB.Size = new System.Drawing.Size(121, 23);
            this.vastuuhloCB.TabIndex = 2;
            this.vastuuhloCB.TextChanged += new System.EventHandler(this.vastuuhloCB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valitse oppilaitos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valitse vastuuhenkilö:";
            // 
            // osLB
            // 
            this.osLB.AutoSize = true;
            this.osLB.Location = new System.Drawing.Point(30, 180);
            this.osLB.Name = "osLB";
            this.osLB.Size = new System.Drawing.Size(41, 15);
            this.osLB.TabIndex = 5;
            this.osLB.Text = "Osoite";
            // 
            // posNLB
            // 
            this.posNLB.AutoSize = true;
            this.posNLB.Location = new System.Drawing.Point(30, 206);
            this.posNLB.Name = "posNLB";
            this.posNLB.Size = new System.Drawing.Size(75, 15);
            this.posNLB.TabIndex = 6;
            this.posNLB.Text = "Postinumero";
            // 
            // posPLB
            // 
            this.posPLB.AutoSize = true;
            this.posPLB.Location = new System.Drawing.Point(30, 231);
            this.posPLB.Name = "posPLB";
            this.posPLB.Size = new System.Drawing.Size(95, 15);
            this.posPLB.TabIndex = 7;
            this.posPLB.Text = "Postitoimipaikka";
            // 
            // puhLB
            // 
            this.puhLB.AutoSize = true;
            this.puhLB.Location = new System.Drawing.Point(30, 259);
            this.puhLB.Name = "puhLB";
            this.puhLB.Size = new System.Drawing.Size(47, 15);
            this.puhLB.TabIndex = 8;
            this.puhLB.Text = "Puhelin";
            // 
            // titLB
            // 
            this.titLB.AutoSize = true;
            this.titLB.Location = new System.Drawing.Point(235, 180);
            this.titLB.Name = "titLB";
            this.titLB.Size = new System.Drawing.Size(36, 15);
            this.titLB.TabIndex = 9;
            this.titLB.Text = "Titteli";
            // 
            // osasLB
            // 
            this.osasLB.AutoSize = true;
            this.osasLB.Location = new System.Drawing.Point(235, 206);
            this.osasLB.Name = "osasLB";
            this.osasLB.Size = new System.Drawing.Size(43, 15);
            this.osasLB.TabIndex = 10;
            this.osasLB.Text = "Osasto";
            // 
            // sahLB
            // 
            this.sahLB.AutoSize = true;
            this.sahLB.Location = new System.Drawing.Point(235, 231);
            this.sahLB.Name = "sahLB";
            this.sahLB.Size = new System.Drawing.Size(65, 15);
            this.sahLB.TabIndex = 11;
            this.sahLB.Text = "Sähköposti";
            // 
            // puh2LB
            // 
            this.puh2LB.AutoSize = true;
            this.puh2LB.Location = new System.Drawing.Point(235, 259);
            this.puh2LB.Name = "puh2LB";
            this.puh2LB.Size = new System.Drawing.Size(47, 15);
            this.puh2LB.TabIndex = 12;
            this.puh2LB.Text = "Puhelin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 300);
            this.Controls.Add(this.puh2LB);
            this.Controls.Add(this.sahLB);
            this.Controls.Add(this.osasLB);
            this.Controls.Add(this.titLB);
            this.Controls.Add(this.puhLB);
            this.Controls.Add(this.posPLB);
            this.Controls.Add(this.posNLB);
            this.Controls.Add(this.osLB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vastuuhloCB);
            this.Controls.Add(this.oppilaitosCB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Oppilaitosten avainhenkilöt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox oppilaitosCB;
        private ComboBox vastuuhloCB;
        private Label label2;
        private Label label3;
        private Label osLB;
        private Label posNLB;
        private Label posPLB;
        private Label puhLB;
        private Label titLB;
        private Label osasLB;
        private Label sahLB;
        private Label puh2LB;
    }
}