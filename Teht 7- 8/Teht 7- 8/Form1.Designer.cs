namespace Teht_7__8
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
            this.LainaTB = new System.Windows.Forms.ComboBox();
            this.NesteetTB = new System.Windows.Forms.ComboBox();
            this.VakuutuksetTB = new System.Windows.Forms.ComboBox();
            this.PesutTB = new System.Windows.Forms.ComboBox();
            this.HuollotTB = new System.Windows.Forms.ComboBox();
            this.RenkaatTB = new System.Windows.Forms.ComboBox();
            this.MuutTB = new System.Windows.Forms.ComboBox();
            this.PolttonesteTB = new System.Windows.Forms.ComboBox();
            this.KilometriCB = new System.Windows.Forms.ComboBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LainaTB
            // 
            this.LainaTB.FormattingEnabled = true;
            this.LainaTB.Location = new System.Drawing.Point(329, 125);
            this.LainaTB.Name = "LainaTB";
            this.LainaTB.Size = new System.Drawing.Size(138, 22);
            this.LainaTB.TabIndex = 0;
            // 
            // NesteetTB
            // 
            this.NesteetTB.FormattingEnabled = true;
            this.NesteetTB.Location = new System.Drawing.Point(329, 152);
            this.NesteetTB.Name = "NesteetTB";
            this.NesteetTB.Size = new System.Drawing.Size(138, 22);
            this.NesteetTB.TabIndex = 1;
            // 
            // VakuutuksetTB
            // 
            this.VakuutuksetTB.FormattingEnabled = true;
            this.VakuutuksetTB.Location = new System.Drawing.Point(329, 179);
            this.VakuutuksetTB.Name = "VakuutuksetTB";
            this.VakuutuksetTB.Size = new System.Drawing.Size(138, 22);
            this.VakuutuksetTB.TabIndex = 2;
            // 
            // PesutTB
            // 
            this.PesutTB.FormattingEnabled = true;
            this.PesutTB.Location = new System.Drawing.Point(329, 206);
            this.PesutTB.Name = "PesutTB";
            this.PesutTB.Size = new System.Drawing.Size(138, 22);
            this.PesutTB.TabIndex = 3;
            // 
            // HuollotTB
            // 
            this.HuollotTB.FormattingEnabled = true;
            this.HuollotTB.Location = new System.Drawing.Point(329, 233);
            this.HuollotTB.Name = "HuollotTB";
            this.HuollotTB.Size = new System.Drawing.Size(138, 22);
            this.HuollotTB.TabIndex = 4;
            // 
            // RenkaatTB
            // 
            this.RenkaatTB.FormattingEnabled = true;
            this.RenkaatTB.Location = new System.Drawing.Point(649, 122);
            this.RenkaatTB.Name = "RenkaatTB";
            this.RenkaatTB.Size = new System.Drawing.Size(138, 22);
            this.RenkaatTB.TabIndex = 5;
            // 
            // MuutTB
            // 
            this.MuutTB.FormattingEnabled = true;
            this.MuutTB.Location = new System.Drawing.Point(649, 149);
            this.MuutTB.Name = "MuutTB";
            this.MuutTB.Size = new System.Drawing.Size(138, 22);
            this.MuutTB.TabIndex = 6;
            // 
            // PolttonesteTB
            // 
            this.PolttonesteTB.FormattingEnabled = true;
            this.PolttonesteTB.Location = new System.Drawing.Point(649, 176);
            this.PolttonesteTB.Name = "PolttonesteTB";
            this.PolttonesteTB.Size = new System.Drawing.Size(138, 22);
            this.PolttonesteTB.TabIndex = 7;
            // 
            // KilometriCB
            // 
            this.KilometriCB.FormattingEnabled = true;
            this.KilometriCB.Items.AddRange(new object[] {
            "5000",
            "10000",
            "15000",
            "20000",
            "25000",
            "35000",
            "40000",
            "45000",
            "50000",
            "55000",
            "60000",
            "65000",
            "75000",
            "80000",
            "85000",
            "95000",
            "100000"});
            this.KilometriCB.Location = new System.Drawing.Point(649, 203);
            this.KilometriCB.Name = "KilometriCB";
            this.KilometriCB.Size = new System.Drawing.Size(138, 22);
            this.KilometriCB.TabIndex = 18;
            this.KilometriCB.SelectedIndexChanged += new System.EventHandler(this.KilometriCB_SelectedIndexChanged);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Swis721 Ex BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VastausLB.Location = new System.Drawing.Point(123, 307);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(45, 14);
            this.VastausLB.TabIndex = 20;
            this.VastausLB.Text = "label1";
            this.VastausLB.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Ex BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(123, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 14);
            this.label1.TabIndex = 21;
            this.label1.Text = "Lainan lyhennys korkoineen:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Swis721 Ex BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(123, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 14);
            this.label2.TabIndex = 22;
            this.label2.Text = "Lisättävät nesteet yms:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Swis721 Ex BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(123, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 14);
            this.label3.TabIndex = 23;
            this.label3.Text = "Vakuutusmaksut:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Swis721 Ex BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(123, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 24;
            this.label4.Text = "Muut kulut:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Swis721 Ex BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(123, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 14);
            this.label5.TabIndex = 25;
            this.label5.Text = "Polttoneste:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Swis721 Ex BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(510, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 14);
            this.label6.TabIndex = 26;
            this.label6.Text = "Pesut:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Swis721 Ex BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(510, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 14);
            this.label7.TabIndex = 27;
            this.label7.Text = "Huollot:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Swis721 Ex BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(510, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 14);
            this.label8.TabIndex = 28;
            this.label8.Text = "Renkaat:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Swis721 Ex BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(510, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 14);
            this.label9.TabIndex = 29;
            this.label9.Text = "Kilometrit/vuosi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Swis721 Ex BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(353, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 22);
            this.label10.TabIndex = 30;
            this.label10.Text = "Auton kustannuslaskuri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 420);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.KilometriCB);
            this.Controls.Add(this.PolttonesteTB);
            this.Controls.Add(this.MuutTB);
            this.Controls.Add(this.RenkaatTB);
            this.Controls.Add(this.HuollotTB);
            this.Controls.Add(this.PesutTB);
            this.Controls.Add(this.VakuutuksetTB);
            this.Controls.Add(this.NesteetTB);
            this.Controls.Add(this.LainaTB);
            this.Font = new System.Drawing.Font("Swis721 Ex BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox LainaTB;
        private ComboBox NesteetTB;
        private ComboBox VakuutuksetTB;
        private ComboBox PesutTB;
        private ComboBox HuollotTB;
        private ComboBox RenkaatTB;
        private ComboBox MuutTB;
        private ComboBox PolttonesteTB;
        private ComboBox KilometriCB;
        private Label VastausLB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}