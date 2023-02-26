namespace DataTimerPicker
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
            this.syntymaAikaDT = new System.Windows.Forms.DateTimePicker();
            this.laskeBT = new System.Windows.Forms.Button();
            this.vuosiLB = new System.Windows.Forms.Label();
            this.kuukausiLV = new System.Windows.Forms.Label();
            this.paivaLV = new System.Windows.Forms.Label();
            this.tunttiLB = new System.Windows.Forms.Label();
            this.minLB = new System.Windows.Forms.Label();
            this.sekLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // syntymaAikaDT
            // 
            this.syntymaAikaDT.Location = new System.Drawing.Point(22, 22);
            this.syntymaAikaDT.Name = "syntymaAikaDT";
            this.syntymaAikaDT.Size = new System.Drawing.Size(200, 23);
            this.syntymaAikaDT.TabIndex = 0;
            // 
            // laskeBT
            // 
            this.laskeBT.Location = new System.Drawing.Point(243, 22);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(75, 23);
            this.laskeBT.TabIndex = 1;
            this.laskeBT.Text = "Laske";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // vuosiLB
            // 
            this.vuosiLB.AutoSize = true;
            this.vuosiLB.Location = new System.Drawing.Point(22, 72);
            this.vuosiLB.Name = "vuosiLB";
            this.vuosiLB.Size = new System.Drawing.Size(49, 15);
            this.vuosiLB.TabIndex = 2;
            this.vuosiLB.Text = "Vuosina";
            this.vuosiLB.Visible = false;
            this.vuosiLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // kuukausiLV
            // 
            this.kuukausiLV.AutoSize = true;
            this.kuukausiLV.Location = new System.Drawing.Point(22, 100);
            this.kuukausiLV.Name = "kuukausiLV";
            this.kuukausiLV.Size = new System.Drawing.Size(68, 15);
            this.kuukausiLV.TabIndex = 3;
            this.kuukausiLV.Text = "Kuukausina";
            this.kuukausiLV.Visible = false;
            // 
            // paivaLV
            // 
            this.paivaLV.AutoSize = true;
            this.paivaLV.Location = new System.Drawing.Point(22, 128);
            this.paivaLV.Name = "paivaLV";
            this.paivaLV.Size = new System.Drawing.Size(45, 15);
            this.paivaLV.TabIndex = 4;
            this.paivaLV.Text = "Päivinä";
            this.paivaLV.Visible = false;
            // 
            // tunttiLB
            // 
            this.tunttiLB.AutoSize = true;
            this.tunttiLB.Location = new System.Drawing.Point(151, 72);
            this.tunttiLB.Name = "tunttiLB";
            this.tunttiLB.Size = new System.Drawing.Size(53, 15);
            this.tunttiLB.TabIndex = 5;
            this.tunttiLB.Text = "Tunteina";
            this.tunttiLB.Visible = false;
            // 
            // minLB
            // 
            this.minLB.AutoSize = true;
            this.minLB.Location = new System.Drawing.Point(151, 100);
            this.minLB.Name = "minLB";
            this.minLB.Size = new System.Drawing.Size(61, 15);
            this.minLB.TabIndex = 6;
            this.minLB.Text = "Minuteina";
            this.minLB.Visible = false;
            // 
            // sekLB
            // 
            this.sekLB.AutoSize = true;
            this.sekLB.Location = new System.Drawing.Point(151, 128);
            this.sekLB.Name = "sekLB";
            this.sekLB.Size = new System.Drawing.Size(65, 15);
            this.sekLB.TabIndex = 7;
            this.sekLB.Text = "Sekunteina";
            this.sekLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 174);
            this.Controls.Add(this.sekLB);
            this.Controls.Add(this.minLB);
            this.Controls.Add(this.tunttiLB);
            this.Controls.Add(this.paivaLV);
            this.Controls.Add(this.kuukausiLV);
            this.Controls.Add(this.vuosiLB);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.syntymaAikaDT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker syntymaAikaDT;
        private Button laskeBT;
        private Label vuosiLB;
        private Label kuukausiLV;
        private Label paivaLV;
        private Label tunttiLB;
        private Label minLB;
        private Label sekLB;
    }
}