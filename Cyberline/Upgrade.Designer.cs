namespace Cyberline
{
    partial class Upgrade
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
            this.lblselectText = new System.Windows.Forms.Label();
            this.listBoxteamSelect = new System.Windows.Forms.ListBox();
            this.lblmemberName = new System.Windows.Forms.Label();
            this.lblProgramming = new System.Windows.Forms.Label();
            this.lblPasswordCracking = new System.Windows.Forms.Label();
            this.lblDDOS = new System.Windows.Forms.Label();
            this.lblIPSpoofing = new System.Windows.Forms.Label();
            this.btnprogrammingAdd = new System.Windows.Forms.Button();
            this.btnpasswordCrackingAdd = new System.Windows.Forms.Button();
            this.btnDDOSAdd = new System.Windows.Forms.Button();
            this.btnIPSpoofingAdd = new System.Windows.Forms.Button();
            this.btnprogrammingSubtract = new System.Windows.Forms.Button();
            this.btnpasswordCrackingSubtract = new System.Windows.Forms.Button();
            this.btnDDOSSubtract = new System.Windows.Forms.Button();
            this.btnIPSpoofingSubtract = new System.Windows.Forms.Button();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.pnlUpgrade = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pnlUpgrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // lblselectText
            // 
            this.lblselectText.AutoSize = true;
            this.lblselectText.BackColor = System.Drawing.Color.Green;
            this.lblselectText.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselectText.Location = new System.Drawing.Point(25, 47);
            this.lblselectText.Name = "lblselectText";
            this.lblselectText.Size = new System.Drawing.Size(486, 27);
            this.lblselectText.TabIndex = 3;
            this.lblselectText.Text = "Select which team member you\'d like to upgrade:";
            // 
            // listBoxteamSelect
            // 
            this.listBoxteamSelect.BackColor = System.Drawing.Color.Green;
            this.listBoxteamSelect.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxteamSelect.FormattingEnabled = true;
            this.listBoxteamSelect.ItemHeight = 39;
            this.listBoxteamSelect.Items.AddRange(new object[] {
            "First",
            "Second",
            "Third"});
            this.listBoxteamSelect.Location = new System.Drawing.Point(384, 84);
            this.listBoxteamSelect.Name = "listBoxteamSelect";
            this.listBoxteamSelect.Size = new System.Drawing.Size(127, 121);
            this.listBoxteamSelect.TabIndex = 2;
            this.listBoxteamSelect.SelectedIndexChanged += new System.EventHandler(this.listBoxteamSelect_SelectedIndexChanged);
            // 
            // lblmemberName
            // 
            this.lblmemberName.AutoSize = true;
            this.lblmemberName.BackColor = System.Drawing.Color.Green;
            this.lblmemberName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmemberName.Location = new System.Drawing.Point(6, 6);
            this.lblmemberName.Name = "lblmemberName";
            this.lblmemberName.Size = new System.Drawing.Size(69, 27);
            this.lblmemberName.TabIndex = 9;
            this.lblmemberName.Text = "Name";
            // 
            // lblProgramming
            // 
            this.lblProgramming.AutoSize = true;
            this.lblProgramming.BackColor = System.Drawing.Color.Green;
            this.lblProgramming.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramming.Location = new System.Drawing.Point(6, 43);
            this.lblProgramming.Name = "lblProgramming";
            this.lblProgramming.Size = new System.Drawing.Size(156, 27);
            this.lblProgramming.TabIndex = 10;
            this.lblProgramming.Text = "Programming: ";
            // 
            // lblPasswordCracking
            // 
            this.lblPasswordCracking.AutoSize = true;
            this.lblPasswordCracking.BackColor = System.Drawing.Color.Green;
            this.lblPasswordCracking.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordCracking.Location = new System.Drawing.Point(6, 80);
            this.lblPasswordCracking.Name = "lblPasswordCracking";
            this.lblPasswordCracking.Size = new System.Drawing.Size(197, 27);
            this.lblPasswordCracking.TabIndex = 11;
            this.lblPasswordCracking.Text = "Password Cracking:";
            // 
            // lblDDOS
            // 
            this.lblDDOS.AutoSize = true;
            this.lblDDOS.BackColor = System.Drawing.Color.Green;
            this.lblDDOS.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDDOS.Location = new System.Drawing.Point(6, 117);
            this.lblDDOS.Name = "lblDDOS";
            this.lblDDOS.Size = new System.Drawing.Size(81, 27);
            this.lblDDOS.TabIndex = 12;
            this.lblDDOS.Text = "DDOS: ";
            // 
            // lblIPSpoofing
            // 
            this.lblIPSpoofing.AutoSize = true;
            this.lblIPSpoofing.BackColor = System.Drawing.Color.Green;
            this.lblIPSpoofing.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPSpoofing.Location = new System.Drawing.Point(6, 154);
            this.lblIPSpoofing.Name = "lblIPSpoofing";
            this.lblIPSpoofing.Size = new System.Drawing.Size(135, 27);
            this.lblIPSpoofing.TabIndex = 13;
            this.lblIPSpoofing.Text = "IP Spoofing: ";
            // 
            // btnprogrammingAdd
            // 
            this.btnprogrammingAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprogrammingAdd.Location = new System.Drawing.Point(229, 43);
            this.btnprogrammingAdd.Name = "btnprogrammingAdd";
            this.btnprogrammingAdd.Size = new System.Drawing.Size(30, 27);
            this.btnprogrammingAdd.TabIndex = 14;
            this.btnprogrammingAdd.Text = "+";
            this.btnprogrammingAdd.UseVisualStyleBackColor = true;
            this.btnprogrammingAdd.Click += new System.EventHandler(this.btnprogrammingAdd_Click);
            // 
            // btnpasswordCrackingAdd
            // 
            this.btnpasswordCrackingAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpasswordCrackingAdd.Location = new System.Drawing.Point(229, 80);
            this.btnpasswordCrackingAdd.Name = "btnpasswordCrackingAdd";
            this.btnpasswordCrackingAdd.Size = new System.Drawing.Size(30, 27);
            this.btnpasswordCrackingAdd.TabIndex = 15;
            this.btnpasswordCrackingAdd.Text = "+";
            this.btnpasswordCrackingAdd.UseVisualStyleBackColor = true;
            this.btnpasswordCrackingAdd.Click += new System.EventHandler(this.btnpasswordCrackingAdd_Click);
            // 
            // btnDDOSAdd
            // 
            this.btnDDOSAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDDOSAdd.Location = new System.Drawing.Point(229, 117);
            this.btnDDOSAdd.Name = "btnDDOSAdd";
            this.btnDDOSAdd.Size = new System.Drawing.Size(30, 27);
            this.btnDDOSAdd.TabIndex = 16;
            this.btnDDOSAdd.Text = "+";
            this.btnDDOSAdd.UseVisualStyleBackColor = true;
            this.btnDDOSAdd.Click += new System.EventHandler(this.btnDDOSAdd_Click);
            // 
            // btnIPSpoofingAdd
            // 
            this.btnIPSpoofingAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIPSpoofingAdd.Location = new System.Drawing.Point(229, 154);
            this.btnIPSpoofingAdd.Name = "btnIPSpoofingAdd";
            this.btnIPSpoofingAdd.Size = new System.Drawing.Size(30, 27);
            this.btnIPSpoofingAdd.TabIndex = 17;
            this.btnIPSpoofingAdd.Text = "+";
            this.btnIPSpoofingAdd.UseVisualStyleBackColor = true;
            this.btnIPSpoofingAdd.Click += new System.EventHandler(this.btnIPSpoofingAdd_Click);
            // 
            // btnprogrammingSubtract
            // 
            this.btnprogrammingSubtract.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprogrammingSubtract.Location = new System.Drawing.Point(265, 43);
            this.btnprogrammingSubtract.Name = "btnprogrammingSubtract";
            this.btnprogrammingSubtract.Size = new System.Drawing.Size(30, 27);
            this.btnprogrammingSubtract.TabIndex = 18;
            this.btnprogrammingSubtract.Text = "-";
            this.btnprogrammingSubtract.UseVisualStyleBackColor = true;
            this.btnprogrammingSubtract.Click += new System.EventHandler(this.btnprogrammingSubtract_Click);
            // 
            // btnpasswordCrackingSubtract
            // 
            this.btnpasswordCrackingSubtract.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpasswordCrackingSubtract.Location = new System.Drawing.Point(265, 80);
            this.btnpasswordCrackingSubtract.Name = "btnpasswordCrackingSubtract";
            this.btnpasswordCrackingSubtract.Size = new System.Drawing.Size(30, 27);
            this.btnpasswordCrackingSubtract.TabIndex = 19;
            this.btnpasswordCrackingSubtract.Text = "-";
            this.btnpasswordCrackingSubtract.UseVisualStyleBackColor = true;
            this.btnpasswordCrackingSubtract.Click += new System.EventHandler(this.btnpasswordCrackingSubtract_Click);
            // 
            // btnDDOSSubtract
            // 
            this.btnDDOSSubtract.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDDOSSubtract.Location = new System.Drawing.Point(265, 117);
            this.btnDDOSSubtract.Name = "btnDDOSSubtract";
            this.btnDDOSSubtract.Size = new System.Drawing.Size(30, 27);
            this.btnDDOSSubtract.TabIndex = 20;
            this.btnDDOSSubtract.Text = "-";
            this.btnDDOSSubtract.UseVisualStyleBackColor = true;
            this.btnDDOSSubtract.Click += new System.EventHandler(this.btnDDOSSubtract_Click);
            // 
            // btnIPSpoofingSubtract
            // 
            this.btnIPSpoofingSubtract.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIPSpoofingSubtract.Location = new System.Drawing.Point(265, 154);
            this.btnIPSpoofingSubtract.Name = "btnIPSpoofingSubtract";
            this.btnIPSpoofingSubtract.Size = new System.Drawing.Size(30, 27);
            this.btnIPSpoofingSubtract.TabIndex = 21;
            this.btnIPSpoofingSubtract.Text = "-";
            this.btnIPSpoofingSubtract.UseVisualStyleBackColor = true;
            this.btnIPSpoofingSubtract.Click += new System.EventHandler(this.btnIPSpoofingSubtract_Click);
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpgrade.Location = new System.Drawing.Point(90, 187);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(205, 39);
            this.btnUpgrade.TabIndex = 22;
            this.btnUpgrade.Text = "Confirm Upgrades";
            this.btnUpgrade.UseVisualStyleBackColor = true;
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            // 
            // pnlUpgrade
            // 
            this.pnlUpgrade.Controls.Add(this.btnUpgrade);
            this.pnlUpgrade.Controls.Add(this.btnIPSpoofingSubtract);
            this.pnlUpgrade.Controls.Add(this.btnDDOSSubtract);
            this.pnlUpgrade.Controls.Add(this.btnpasswordCrackingSubtract);
            this.pnlUpgrade.Controls.Add(this.btnprogrammingSubtract);
            this.pnlUpgrade.Controls.Add(this.btnIPSpoofingAdd);
            this.pnlUpgrade.Controls.Add(this.btnDDOSAdd);
            this.pnlUpgrade.Controls.Add(this.btnpasswordCrackingAdd);
            this.pnlUpgrade.Controls.Add(this.btnprogrammingAdd);
            this.pnlUpgrade.Controls.Add(this.lblIPSpoofing);
            this.pnlUpgrade.Controls.Add(this.lblDDOS);
            this.pnlUpgrade.Controls.Add(this.lblPasswordCracking);
            this.pnlUpgrade.Controls.Add(this.lblProgramming);
            this.pnlUpgrade.Controls.Add(this.lblmemberName);
            this.pnlUpgrade.Location = new System.Drawing.Point(19, 41);
            this.pnlUpgrade.Name = "pnlUpgrade";
            this.pnlUpgrade.Size = new System.Drawing.Size(306, 234);
            this.pnlUpgrade.TabIndex = 23;
            this.pnlUpgrade.Visible = false;
            // 
            // Upgrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(255)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(714, 277);
            this.Controls.Add(this.pnlUpgrade);
            this.Controls.Add(this.lblselectText);
            this.Controls.Add(this.listBoxteamSelect);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Upgrade";
            this.Text = "Upgrade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Upgrade_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlUpgrade.ResumeLayout(false);
            this.pnlUpgrade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label lblselectText;
        private System.Windows.Forms.ListBox listBoxteamSelect;
        private System.Windows.Forms.Label lblmemberName;
        private System.Windows.Forms.Label lblProgramming;
        private System.Windows.Forms.Label lblPasswordCracking;
        private System.Windows.Forms.Label lblDDOS;
        private System.Windows.Forms.Label lblIPSpoofing;
        private System.Windows.Forms.Button btnprogrammingAdd;
        private System.Windows.Forms.Button btnpasswordCrackingAdd;
        private System.Windows.Forms.Button btnDDOSAdd;
        private System.Windows.Forms.Button btnIPSpoofingAdd;
        private System.Windows.Forms.Button btnprogrammingSubtract;
        private System.Windows.Forms.Button btnpasswordCrackingSubtract;
        private System.Windows.Forms.Button btnDDOSSubtract;
        private System.Windows.Forms.Button btnIPSpoofingSubtract;
        private System.Windows.Forms.Button btnUpgrade;
        private System.Windows.Forms.Panel pnlUpgrade;
    }
}