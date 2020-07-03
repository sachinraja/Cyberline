namespace Cyberline
{
    partial class Computer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Computer));
            this.picMenuButton = new System.Windows.Forms.PictureBox();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnReputation = new System.Windows.Forms.Button();
            this.btnCollectives = new System.Windows.Forms.Button();
            this.btnFreelance = new System.Windows.Forms.Button();
            this.pnlContracts = new System.Windows.Forms.Panel();
            this.radblackHat = new System.Windows.Forms.RadioButton();
            this.radwhiteHat = new System.Windows.Forms.RadioButton();
            this.pnlFreelance = new System.Windows.Forms.Panel();
            this.btnTeam = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btncurrentContract = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncurrentFreelance = new System.Windows.Forms.Button();
            this.pnlCollective = new System.Windows.Forms.Panel();
            this.btnmyCollective = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuButton)).BeginInit();
            this.pnlContracts.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picMenuButton
            // 
            this.picMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("picMenuButton.Image")));
            this.picMenuButton.Location = new System.Drawing.Point(0, 30);
            this.picMenuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMenuButton.Name = "picMenuButton";
            this.picMenuButton.Size = new System.Drawing.Size(40, 39);
            this.picMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenuButton.TabIndex = 0;
            this.picMenuButton.TabStop = false;
            this.picMenuButton.Click += new System.EventHandler(this.picMenuButton_Click);
            this.picMenuButton.MouseEnter += new System.EventHandler(this.Click_MouseEnter);
            this.picMenuButton.MouseLeave += new System.EventHandler(this.Click_MouseLeave);
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpgrade.Location = new System.Drawing.Point(0, 385);
            this.btnUpgrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(156, 35);
            this.btnUpgrade.TabIndex = 1;
            this.btnUpgrade.Text = "Upgrade";
            this.btnUpgrade.UseVisualStyleBackColor = true;
            this.btnUpgrade.Visible = false;
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            // 
            // btnContracts
            // 
            this.btnContracts.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContracts.Location = new System.Drawing.Point(0, 190);
            this.btnContracts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(156, 35);
            this.btnContracts.TabIndex = 2;
            this.btnContracts.Text = "Contracts";
            this.btnContracts.UseVisualStyleBackColor = true;
            this.btnContracts.Visible = false;
            this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click);
            // 
            // btnReputation
            // 
            this.btnReputation.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReputation.Location = new System.Drawing.Point(0, 307);
            this.btnReputation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReputation.Name = "btnReputation";
            this.btnReputation.Size = new System.Drawing.Size(156, 35);
            this.btnReputation.TabIndex = 4;
            this.btnReputation.Text = "Reputation";
            this.btnReputation.UseVisualStyleBackColor = true;
            this.btnReputation.Visible = false;
            this.btnReputation.Click += new System.EventHandler(this.btnReputation_Click);
            // 
            // btnCollectives
            // 
            this.btnCollectives.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollectives.Location = new System.Drawing.Point(0, 346);
            this.btnCollectives.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCollectives.Name = "btnCollectives";
            this.btnCollectives.Size = new System.Drawing.Size(156, 35);
            this.btnCollectives.TabIndex = 5;
            this.btnCollectives.Text = "Collectives";
            this.btnCollectives.UseVisualStyleBackColor = true;
            this.btnCollectives.Visible = false;
            this.btnCollectives.Click += new System.EventHandler(this.btnCollectives_Click);
            // 
            // btnFreelance
            // 
            this.btnFreelance.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFreelance.Location = new System.Drawing.Point(0, 229);
            this.btnFreelance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFreelance.Name = "btnFreelance";
            this.btnFreelance.Size = new System.Drawing.Size(156, 35);
            this.btnFreelance.TabIndex = 6;
            this.btnFreelance.Text = "Freelance";
            this.btnFreelance.UseVisualStyleBackColor = true;
            this.btnFreelance.Visible = false;
            this.btnFreelance.Click += new System.EventHandler(this.btnFreelance_Click);
            // 
            // pnlContracts
            // 
            this.pnlContracts.Controls.Add(this.radblackHat);
            this.pnlContracts.Controls.Add(this.radwhiteHat);
            this.pnlContracts.Location = new System.Drawing.Point(163, 73);
            this.pnlContracts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContracts.Name = "pnlContracts";
            this.pnlContracts.Size = new System.Drawing.Size(628, 483);
            this.pnlContracts.TabIndex = 8;
            this.pnlContracts.Visible = false;
            // 
            // radblackHat
            // 
            this.radblackHat.AutoSize = true;
            this.radblackHat.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radblackHat.Location = new System.Drawing.Point(19, 52);
            this.radblackHat.Name = "radblackHat";
            this.radblackHat.Size = new System.Drawing.Size(122, 31);
            this.radblackHat.TabIndex = 14;
            this.radblackHat.Text = "Black Hat";
            this.radblackHat.UseVisualStyleBackColor = true;
            this.radblackHat.CheckedChanged += new System.EventHandler(this.Hat_CheckedChanged);
            // 
            // radwhiteHat
            // 
            this.radwhiteHat.AutoSize = true;
            this.radwhiteHat.Checked = true;
            this.radwhiteHat.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radwhiteHat.Location = new System.Drawing.Point(19, 15);
            this.radwhiteHat.Name = "radwhiteHat";
            this.radwhiteHat.Size = new System.Drawing.Size(127, 31);
            this.radwhiteHat.TabIndex = 13;
            this.radwhiteHat.TabStop = true;
            this.radwhiteHat.Text = "White Hat";
            this.radwhiteHat.UseVisualStyleBackColor = true;
            this.radwhiteHat.CheckedChanged += new System.EventHandler(this.Hat_CheckedChanged);
            // 
            // pnlFreelance
            // 
            this.pnlFreelance.Location = new System.Drawing.Point(163, 73);
            this.pnlFreelance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFreelance.Name = "pnlFreelance";
            this.pnlFreelance.Size = new System.Drawing.Size(628, 483);
            this.pnlFreelance.TabIndex = 8;
            this.pnlFreelance.Visible = false;
            // 
            // btnTeam
            // 
            this.btnTeam.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeam.Location = new System.Drawing.Point(0, 268);
            this.btnTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTeam.Name = "btnTeam";
            this.btnTeam.Size = new System.Drawing.Size(156, 35);
            this.btnTeam.TabIndex = 8;
            this.btnTeam.Text = "Team";
            this.btnTeam.UseVisualStyleBackColor = true;
            this.btnTeam.Visible = false;
            this.btnTeam.Click += new System.EventHandler(this.btnTeam_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 30);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // btncurrentContract
            // 
            this.btncurrentContract.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncurrentContract.Location = new System.Drawing.Point(2, 73);
            this.btncurrentContract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncurrentContract.Name = "btncurrentContract";
            this.btncurrentContract.Size = new System.Drawing.Size(156, 35);
            this.btncurrentContract.TabIndex = 10;
            this.btncurrentContract.Text = "Current Contract";
            this.btncurrentContract.UseVisualStyleBackColor = true;
            this.btncurrentContract.Visible = false;
            this.btncurrentContract.Click += new System.EventHandler(this.btncurrentContract_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.Green;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(692, 42);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(60, 27);
            this.lblBalance.TabIndex = 11;
            this.lblBalance.Text = "$500";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(660, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btncurrentFreelance
            // 
            this.btncurrentFreelance.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncurrentFreelance.Location = new System.Drawing.Point(0, 112);
            this.btncurrentFreelance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncurrentFreelance.Name = "btncurrentFreelance";
            this.btncurrentFreelance.Size = new System.Drawing.Size(156, 35);
            this.btncurrentFreelance.TabIndex = 13;
            this.btncurrentFreelance.Text = "Current Freelance";
            this.btncurrentFreelance.UseVisualStyleBackColor = true;
            this.btncurrentFreelance.Visible = false;
            this.btncurrentFreelance.Click += new System.EventHandler(this.btncurrentFreelance_Click);
            // 
            // pnlCollective
            // 
            this.pnlCollective.Location = new System.Drawing.Point(163, 73);
            this.pnlCollective.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCollective.Name = "pnlCollective";
            this.pnlCollective.Size = new System.Drawing.Size(628, 483);
            this.pnlCollective.TabIndex = 8;
            this.pnlCollective.Visible = false;
            // 
            // btnmyCollective
            // 
            this.btnmyCollective.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmyCollective.Location = new System.Drawing.Point(2, 151);
            this.btnmyCollective.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmyCollective.Name = "btnmyCollective";
            this.btnmyCollective.Size = new System.Drawing.Size(156, 35);
            this.btnmyCollective.TabIndex = 14;
            this.btnmyCollective.Text = "My Collective";
            this.btnmyCollective.UseVisualStyleBackColor = true;
            this.btnmyCollective.Visible = false;
            this.btnmyCollective.Click += new System.EventHandler(this.btnmyCollective_Click);
            // 
            // Computer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(255)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(798, 568);
            this.Controls.Add(this.btnmyCollective);
            this.Controls.Add(this.pnlCollective);
            this.Controls.Add(this.btncurrentFreelance);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btncurrentContract);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnTeam);
            this.Controls.Add(this.btnFreelance);
            this.Controls.Add(this.btnCollectives);
            this.Controls.Add(this.btnReputation);
            this.Controls.Add(this.btnContracts);
            this.Controls.Add(this.picMenuButton);
            this.Controls.Add(this.btnUpgrade);
            this.Controls.Add(this.pnlContracts);
            this.Controls.Add(this.pnlFreelance);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Computer";
            this.Text = " Computer";
            this.Load += new System.EventHandler(this.Computer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMenuButton)).EndInit();
            this.pnlContracts.ResumeLayout(false);
            this.pnlContracts.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMenuButton;
        private System.Windows.Forms.Button btnUpgrade;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Button btnReputation;
        private System.Windows.Forms.Button btnCollectives;
        private System.Windows.Forms.Button btnFreelance;
        private System.Windows.Forms.Panel pnlContracts;
        private System.Windows.Forms.Button btnTeam;
        private System.Windows.Forms.Panel pnlFreelance;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btncurrentContract;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.RadioButton radblackHat;
        public System.Windows.Forms.RadioButton radwhiteHat;
        private System.Windows.Forms.Button btncurrentFreelance;
        private System.Windows.Forms.Panel pnlCollective;
        private System.Windows.Forms.Button btnmyCollective;
    }
}