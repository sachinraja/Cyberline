namespace Cyberline
{
    partial class Reputation
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblreputationStatus = new System.Windows.Forms.Label();
            this.lblwhiteHat = new System.Windows.Forms.Label();
            this.lblblackHat = new System.Windows.Forms.Label();
            this.lblreputationSlider = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // lblreputationStatus
            // 
            this.lblreputationStatus.AutoSize = true;
            this.lblreputationStatus.BackColor = System.Drawing.Color.Green;
            this.lblreputationStatus.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreputationStatus.Location = new System.Drawing.Point(12, 45);
            this.lblreputationStatus.Name = "lblreputationStatus";
            this.lblreputationStatus.Size = new System.Drawing.Size(82, 31);
            this.lblreputationStatus.TabIndex = 2;
            this.lblreputationStatus.Text = "label1";
            // 
            // lblwhiteHat
            // 
            this.lblwhiteHat.BackColor = System.Drawing.Color.White;
            this.lblwhiteHat.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwhiteHat.Location = new System.Drawing.Point(7, 90);
            this.lblwhiteHat.Name = "lblwhiteHat";
            this.lblwhiteHat.Size = new System.Drawing.Size(200, 30);
            this.lblwhiteHat.TabIndex = 3;
            // 
            // lblblackHat
            // 
            this.lblblackHat.BackColor = System.Drawing.Color.Black;
            this.lblblackHat.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblblackHat.Location = new System.Drawing.Point(222, 90);
            this.lblblackHat.Name = "lblblackHat";
            this.lblblackHat.Size = new System.Drawing.Size(200, 30);
            this.lblblackHat.TabIndex = 4;
            // 
            // lblreputationSlider
            // 
            this.lblreputationSlider.BackColor = System.Drawing.Color.DarkGray;
            this.lblreputationSlider.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreputationSlider.Location = new System.Drawing.Point(207, 81);
            this.lblreputationSlider.Name = "lblreputationSlider";
            this.lblreputationSlider.Size = new System.Drawing.Size(15, 50);
            this.lblreputationSlider.TabIndex = 5;
            // 
            // Reputation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(255)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(430, 140);
            this.Controls.Add(this.lblreputationSlider);
            this.Controls.Add(this.lblblackHat);
            this.Controls.Add(this.lblwhiteHat);
            this.Controls.Add(this.lblreputationStatus);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reputation";
            this.Text = "Reputation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reputation_FormClosing);
            this.Load += new System.EventHandler(this.Reputation_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label lblreputationStatus;
        private System.Windows.Forms.Label lblwhiteHat;
        private System.Windows.Forms.Label lblblackHat;
        private System.Windows.Forms.Label lblreputationSlider;
    }
}