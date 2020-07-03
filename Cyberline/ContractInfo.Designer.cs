namespace Cyberline
{
    partial class ContractInfo
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecommendedSkillsText = new System.Windows.Forms.Label();
            this.txtSkills = new System.Windows.Forms.TextBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnHack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(12, 50);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(200, 200);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Green;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(218, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 31);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(497, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // lblRecommendedSkillsText
            // 
            this.lblRecommendedSkillsText.AutoSize = true;
            this.lblRecommendedSkillsText.BackColor = System.Drawing.Color.Green;
            this.lblRecommendedSkillsText.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecommendedSkillsText.Location = new System.Drawing.Point(218, 169);
            this.lblRecommendedSkillsText.Name = "lblRecommendedSkillsText";
            this.lblRecommendedSkillsText.Size = new System.Drawing.Size(257, 31);
            this.lblRecommendedSkillsText.TabIndex = 3;
            this.lblRecommendedSkillsText.Text = "Recommended Skills:";
            // 
            // txtSkills
            // 
            this.txtSkills.BackColor = System.Drawing.Color.Green;
            this.txtSkills.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSkills.Location = new System.Drawing.Point(218, 203);
            this.txtSkills.Multiline = true;
            this.txtSkills.Name = "txtSkills";
            this.txtSkills.ReadOnly = true;
            this.txtSkills.Size = new System.Drawing.Size(257, 126);
            this.txtSkills.TabIndex = 4;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.BackColor = System.Drawing.Color.Green;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(218, 91);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(84, 31);
            this.lblPayment.TabIndex = 5;
            this.lblPayment.Text = "$1000";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Green;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(218, 130);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(86, 31);
            this.lblLevel.TabIndex = 6;
            this.lblLevel.Text = "Level: ";
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(39, 255);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(153, 44);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnHack
            // 
            this.btnHack.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHack.Location = new System.Drawing.Point(39, 303);
            this.btnHack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHack.Name = "btnHack";
            this.btnHack.Size = new System.Drawing.Size(153, 44);
            this.btnHack.TabIndex = 8;
            this.btnHack.Text = "Hack";
            this.btnHack.UseVisualStyleBackColor = true;
            this.btnHack.Visible = false;
            this.btnHack.Click += new System.EventHandler(this.btnHack_Click);
            // 
            // ContractInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(255)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(497, 350);
            this.Controls.Add(this.btnHack);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.txtSkills);
            this.Controls.Add(this.lblRecommendedSkillsText);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ContractInfo";
            this.Text = "Contract Info";
            this.Load += new System.EventHandler(this.ContractInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label lblRecommendedSkillsText;
        private System.Windows.Forms.TextBox txtSkills;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnHack;
    }
}