namespace Oppilashallintajarjestelma
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tietotauluDG = new System.Windows.Forms.DataGridView();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.talennaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            this.paivitaBT = new System.Windows.Forms.Button();
            this.idTB = new System.Windows.Forms.TextBox();
            this.enimiTB = new System.Windows.Forms.TextBox();
            this.snimiTB = new System.Windows.Forms.TextBox();
            this.onroTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.puhTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tietotauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // tietotauluDG
            // 
            this.tietotauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tietotauluDG.Location = new System.Drawing.Point(12, 236);
            this.tietotauluDG.Name = "tietotauluDG";
            this.tietotauluDG.Size = new System.Drawing.Size(663, 150);
            this.tietotauluDG.TabIndex = 0;
            this.tietotauluDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tietotauluDG_CellContentClick);
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Location = new System.Drawing.Point(87, 151);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(75, 23);
            this.tyhjennaBT.TabIndex = 1;
            this.tyhjennaBT.Text = "TYHJENNÄ";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click);
            // 
            // talennaBT
            // 
            this.talennaBT.Location = new System.Drawing.Point(168, 151);
            this.talennaBT.Name = "talennaBT";
            this.talennaBT.Size = new System.Drawing.Size(75, 23);
            this.talennaBT.TabIndex = 2;
            this.talennaBT.Text = "TALENNA";
            this.talennaBT.UseVisualStyleBackColor = true;
            this.talennaBT.Click += new System.EventHandler(this.talennaBT_Click);
            // 
            // poistaBT
            // 
            this.poistaBT.Location = new System.Drawing.Point(517, 151);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(75, 23);
            this.poistaBT.TabIndex = 4;
            this.poistaBT.Text = "POISTA";
            this.poistaBT.UseVisualStyleBackColor = true;
            this.poistaBT.Click += new System.EventHandler(this.poistaBT_Click);
            // 
            // paivitaBT
            // 
            this.paivitaBT.Location = new System.Drawing.Point(436, 151);
            this.paivitaBT.Name = "paivitaBT";
            this.paivitaBT.Size = new System.Drawing.Size(75, 23);
            this.paivitaBT.TabIndex = 3;
            this.paivitaBT.Text = "PÄIVITÄ";
            this.paivitaBT.UseVisualStyleBackColor = true;
            this.paivitaBT.Click += new System.EventHandler(this.paivitaBT_Click);
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(167, 12);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(100, 20);
            this.idTB.TabIndex = 5;
            // 
            // enimiTB
            // 
            this.enimiTB.Location = new System.Drawing.Point(167, 38);
            this.enimiTB.Name = "enimiTB";
            this.enimiTB.Size = new System.Drawing.Size(100, 20);
            this.enimiTB.TabIndex = 6;
            // 
            // snimiTB
            // 
            this.snimiTB.Location = new System.Drawing.Point(167, 64);
            this.snimiTB.Name = "snimiTB";
            this.snimiTB.Size = new System.Drawing.Size(100, 20);
            this.snimiTB.TabIndex = 7;
            // 
            // onroTB
            // 
            this.onroTB.Location = new System.Drawing.Point(529, 64);
            this.onroTB.Name = "onroTB";
            this.onroTB.Size = new System.Drawing.Size(100, 20);
            this.onroTB.TabIndex = 10;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(529, 38);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(100, 20);
            this.emailTB.TabIndex = 9;
            // 
            // puhTB
            // 
            this.puhTB.Location = new System.Drawing.Point(529, 12);
            this.puhTB.Name = "puhTB";
            this.puhTB.Size = new System.Drawing.Size(100, 20);
            this.puhTB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Etunimi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sukunimi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Opiskelijanumero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sähköposti:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Puhelin:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 414);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.onroTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.puhTB);
            this.Controls.Add(this.snimiTB);
            this.Controls.Add(this.enimiTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.poistaBT);
            this.Controls.Add(this.paivitaBT);
            this.Controls.Add(this.talennaBT);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.tietotauluDG);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tietotauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tietotauluDG;
        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Button talennaBT;
        private System.Windows.Forms.Button poistaBT;
        private System.Windows.Forms.Button paivitaBT;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox enimiTB;
        private System.Windows.Forms.TextBox snimiTB;
        private System.Windows.Forms.TextBox onroTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox puhTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

