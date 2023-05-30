namespace teht_16
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
            this.components = new System.ComponentModel.Container();
            this.minuuttiCB = new System.Windows.Forms.ComboBox();
            this.startBT = new System.Windows.Forms.Button();
            this.stopBT = new System.Windows.Forms.Button();
            this.aikaLB = new System.Windows.Forms.Label();
            this.sekCM = new System.Windows.Forms.ComboBox();
            this.sekLB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ajastinTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // minuuttiCB
            // 
            this.minuuttiCB.FormattingEnabled = true;
            this.minuuttiCB.Location = new System.Drawing.Point(34, 73);
            this.minuuttiCB.Name = "minuuttiCB";
            this.minuuttiCB.Size = new System.Drawing.Size(80, 23);
            this.minuuttiCB.TabIndex = 0;
            // 
            // startBT
            // 
            this.startBT.Location = new System.Drawing.Point(34, 174);
            this.startBT.Name = "startBT";
            this.startBT.Size = new System.Drawing.Size(80, 35);
            this.startBT.TabIndex = 1;
            this.startBT.Text = "Start";
            this.startBT.UseVisualStyleBackColor = true;
            this.startBT.Click += new System.EventHandler(this.startBT_Click);
            // 
            // stopBT
            // 
            this.stopBT.Location = new System.Drawing.Point(125, 174);
            this.stopBT.Name = "stopBT";
            this.stopBT.Size = new System.Drawing.Size(75, 35);
            this.stopBT.TabIndex = 2;
            this.stopBT.Text = "Stop";
            this.stopBT.UseVisualStyleBackColor = true;
            this.stopBT.Click += new System.EventHandler(this.stopBT_Click);
            // 
            // aikaLB
            // 
            this.aikaLB.AutoSize = true;
            this.aikaLB.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aikaLB.Location = new System.Drawing.Point(46, 99);
            this.aikaLB.Name = "aikaLB";
            this.aikaLB.Size = new System.Drawing.Size(142, 65);
            this.aikaLB.TabIndex = 3;
            this.aikaLB.Text = "00:00";
            // 
            // sekCM
            // 
            this.sekCM.FormattingEnabled = true;
            this.sekCM.Location = new System.Drawing.Point(120, 73);
            this.sekCM.Name = "sekCM";
            this.sekCM.Size = new System.Drawing.Size(80, 23);
            this.sekCM.TabIndex = 4;
            // 
            // sekLB
            // 
            this.sekLB.AutoSize = true;
            this.sekLB.Location = new System.Drawing.Point(132, 55);
            this.sekLB.Name = "sekLB";
            this.sekLB.Size = new System.Drawing.Size(56, 15);
            this.sekLB.TabIndex = 5;
            this.sekLB.Text = "Sekunnit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Minuutit:";
            // 
            // ajastinTM
            // 
            this.ajastinTM.Interval = 1000;
            this.ajastinTM.Tick += new System.EventHandler(this.ajastinTM_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 234);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sekLB);
            this.Controls.Add(this.sekCM);
            this.Controls.Add(this.aikaLB);
            this.Controls.Add(this.stopBT);
            this.Controls.Add(this.startBT);
            this.Controls.Add(this.minuuttiCB);
            this.Name = "Form1";
            this.Text = "Laskuri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox minuuttiCB;
        private Button startBT;
        private Button stopBT;
        private Label aikaLB;
        private ComboBox sekCM;
        private Label sekLB;
        private Label label3;
        private System.Windows.Forms.Timer ajastinTM;
    }
}