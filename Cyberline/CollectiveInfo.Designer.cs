namespace Cyberline
{
    partial class CollectiveInfo
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
            this.lblName = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnJoin = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblReputationRequirement = new System.Windows.Forms.Label();
            this.btnContract = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Green;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(218, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 31);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(12, 59);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(200, 200);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 8;
            this.picLogo.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(497, 30);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoin.Location = new System.Drawing.Point(32, 264);
            this.btnJoin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(153, 44);
            this.btnJoin.TabIndex = 15;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Green;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(218, 182);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(86, 31);
            this.lblLevel.TabIndex = 14;
            this.lblLevel.Text = "Level: ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Green;
            this.lblType.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(218, 100);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(55, 31);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Hat";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.Green;
            this.lblSize.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(218, 142);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(66, 31);
            this.lblSize.TabIndex = 16;
            this.lblSize.Text = "Size:";
            // 
            // lblReputationRequirement
            // 
            this.lblReputationRequirement.AutoSize = true;
            this.lblReputationRequirement.BackColor = System.Drawing.Color.Green;
            this.lblReputationRequirement.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReputationRequirement.Location = new System.Drawing.Point(218, 224);
            this.lblReputationRequirement.Name = "lblReputationRequirement";
            this.lblReputationRequirement.Size = new System.Drawing.Size(176, 62);
            this.lblReputationRequirement.TabIndex = 17;
            this.lblReputationRequirement.Text = "Reputation\r\nRequirement: \r\n";
            // 
            // btnContract
            // 
            this.btnContract.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContract.Location = new System.Drawing.Point(32, 312);
            this.btnContract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContract.Name = "btnContract";
            this.btnContract.Size = new System.Drawing.Size(153, 44);
            this.btnContract.TabIndex = 18;
            this.btnContract.Text = "Contract";
            this.btnContract.UseVisualStyleBackColor = true;
            this.btnContract.Visible = false;
            this.btnContract.Click += new System.EventHandler(this.btnContract_Click);
            // 
            // CollectiveInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(255)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(497, 358);
            this.Controls.Add(this.btnContract);
            this.Controls.Add(this.lblReputationRequirement);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblType);
            this.Name = "CollectiveInfo";
            this.Text = "Collective Info";
            this.Load += new System.EventHandler(this.CollectiveInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblReputationRequirement;
        private System.Windows.Forms.Button btnContract;
    }
}