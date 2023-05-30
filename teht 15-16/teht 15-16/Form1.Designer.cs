namespace teht_15_16
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
            this.kelloLB = new System.Windows.Forms.Label();
            this.startBT = new System.Windows.Forms.Button();
            this.stopBT = new System.Windows.Forms.Button();
            this.resetBT = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // kelloLB
            // 
            this.kelloLB.AutoSize = true;
            this.kelloLB.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kelloLB.Location = new System.Drawing.Point(5, 9);
            this.kelloLB.Name = "kelloLB";
            this.kelloLB.Size = new System.Drawing.Size(292, 65);
            this.kelloLB.TabIndex = 0;
            this.kelloLB.Text = "00:00:00.000";
            // 
            // startBT
            // 
            this.startBT.Location = new System.Drawing.Point(19, 107);
            this.startBT.Name = "startBT";
            this.startBT.Size = new System.Drawing.Size(75, 23);
            this.startBT.TabIndex = 1;
            this.startBT.Text = "Start";
            this.startBT.UseVisualStyleBackColor = true;
            this.startBT.Click += new System.EventHandler(this.startBT_Click);
            // 
            // stopBT
            // 
            this.stopBT.Location = new System.Drawing.Point(115, 107);
            this.stopBT.Name = "stopBT";
            this.stopBT.Size = new System.Drawing.Size(75, 23);
            this.stopBT.TabIndex = 2;
            this.stopBT.Text = "Stop";
            this.stopBT.UseVisualStyleBackColor = true;
            this.stopBT.Click += new System.EventHandler(this.stopBT_Click);
            // 
            // resetBT
            // 
            this.resetBT.Location = new System.Drawing.Point(207, 107);
            this.resetBT.Name = "resetBT";
            this.resetBT.Size = new System.Drawing.Size(75, 23);
            this.resetBT.TabIndex = 3;
            this.resetBT.Text = "Reset";
            this.resetBT.UseVisualStyleBackColor = true;
            this.resetBT.Click += new System.EventHandler(this.resetBT_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 141);
            this.Controls.Add(this.resetBT);
            this.Controls.Add(this.stopBT);
            this.Controls.Add(this.startBT);
            this.Controls.Add(this.kelloLB);
            this.Name = "Form1";
            this.Text = "Sekuntikello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label kelloLB;
        private Button startBT;
        private Button stopBT;
        private Button resetBT;
        private System.Windows.Forms.Timer timer1;
    }
}