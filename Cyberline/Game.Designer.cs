namespace Cyberline
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrgameTime = new System.Windows.Forms.Timer(this.components);
            this.lblClick = new System.Windows.Forms.Label();
            this.pnlsquareClick = new System.Windows.Forms.Panel();
            this.pnlType = new System.Windows.Forms.Panel();
            this.lbltypeWord = new System.Windows.Forms.Label();
            this.lbltypeText = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblsuccessChance = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblstartingTime = new System.Windows.Forms.Label();
            this.txtgameStats = new System.Windows.Forms.TextBox();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.pnlsquareClick.SuspendLayout();
            this.pnlType.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // tmrgameTime
            // 
            this.tmrgameTime.Interval = 1000;
            this.tmrgameTime.Tick += new System.EventHandler(this.tmrgameTime_Tick);
            // 
            // lblClick
            // 
            this.lblClick.BackColor = System.Drawing.Color.Green;
            this.lblClick.Location = new System.Drawing.Point(387, 172);
            this.lblClick.Name = "lblClick";
            this.lblClick.Size = new System.Drawing.Size(30, 30);
            this.lblClick.TabIndex = 1;
            this.lblClick.Click += new System.EventHandler(this.lblClick_Click);
            this.lblClick.MouseEnter += new System.EventHandler(this.lblClick_MouseEnter);
            this.lblClick.MouseLeave += new System.EventHandler(this.lblClick_MouseLeave);
            // 
            // pnlsquareClick
            // 
            this.pnlsquareClick.Controls.Add(this.lblClick);
            this.pnlsquareClick.Location = new System.Drawing.Point(0, 33);
            this.pnlsquareClick.Name = "pnlsquareClick";
            this.pnlsquareClick.Size = new System.Drawing.Size(800, 420);
            this.pnlsquareClick.TabIndex = 2;
            this.pnlsquareClick.Visible = false;
            // 
            // pnlType
            // 
            this.pnlType.Controls.Add(this.lbltypeWord);
            this.pnlType.Controls.Add(this.lbltypeText);
            this.pnlType.Controls.Add(this.txtType);
            this.pnlType.Location = new System.Drawing.Point(0, 33);
            this.pnlType.Name = "pnlType";
            this.pnlType.Size = new System.Drawing.Size(800, 417);
            this.pnlType.TabIndex = 3;
            this.pnlType.Visible = false;
            // 
            // lbltypeWord
            // 
            this.lbltypeWord.AutoSize = true;
            this.lbltypeWord.BackColor = System.Drawing.Color.Green;
            this.lbltypeWord.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltypeWord.Location = new System.Drawing.Point(22, 87);
            this.lbltypeWord.Name = "lbltypeWord";
            this.lbltypeWord.Size = new System.Drawing.Size(77, 31);
            this.lbltypeWord.TabIndex = 8;
            this.lbltypeWord.Text = "Word";
            // 
            // lbltypeText
            // 
            this.lbltypeText.AutoSize = true;
            this.lbltypeText.BackColor = System.Drawing.Color.Green;
            this.lbltypeText.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltypeText.Location = new System.Drawing.Point(22, 45);
            this.lbltypeText.Name = "lbltypeText";
            this.lbltypeText.Size = new System.Drawing.Size(351, 31);
            this.lbltypeText.TabIndex = 6;
            this.lbltypeText.Text = "Type this word and hit enter: ";
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.Green;
            this.txtType.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(20, 145);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(345, 34);
            this.txtType.TabIndex = 7;
            this.txtType.TextChanged += new System.EventHandler(this.txtType_TextChanged);
            // 
            // lblsuccessChance
            // 
            this.lblsuccessChance.AutoSize = true;
            this.lblsuccessChance.BackColor = System.Drawing.Color.Green;
            this.lblsuccessChance.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsuccessChance.Location = new System.Drawing.Point(490, 33);
            this.lblsuccessChance.Name = "lblsuccessChance";
            this.lblsuccessChance.Size = new System.Drawing.Size(225, 31);
            this.lblsuccessChance.TabIndex = 4;
            this.lblsuccessChance.Text = "Chance of Success";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Green;
            this.lblTime.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(375, 33);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(42, 31);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "20";
            // 
            // lblstartingTime
            // 
            this.lblstartingTime.AutoSize = true;
            this.lblstartingTime.BackColor = System.Drawing.Color.Green;
            this.lblstartingTime.Font = new System.Drawing.Font("Microsoft YaHei", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstartingTime.Location = new System.Drawing.Point(324, 110);
            this.lblstartingTime.Name = "lblstartingTime";
            this.lblstartingTime.Size = new System.Drawing.Size(135, 156);
            this.lblstartingTime.TabIndex = 3;
            this.lblstartingTime.Text = "3";
            // 
            // txtgameStats
            // 
            this.txtgameStats.BackColor = System.Drawing.Color.Green;
            this.txtgameStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgameStats.Location = new System.Drawing.Point(235, 77);
            this.txtgameStats.Multiline = true;
            this.txtgameStats.Name = "txtgameStats";
            this.txtgameStats.ReadOnly = true;
            this.txtgameStats.Size = new System.Drawing.Size(300, 250);
            this.txtgameStats.TabIndex = 5;
            this.txtgameStats.Visible = false;
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Visible = false;
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(255)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblsuccessChance);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblstartingTime);
            this.Controls.Add(this.txtgameStats);
            this.Controls.Add(this.pnlType);
            this.Controls.Add(this.pnlsquareClick);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlsquareClick.ResumeLayout(false);
            this.pnlType.ResumeLayout(false);
            this.pnlType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.Timer tmrgameTime;
        private System.Windows.Forms.Label lblClick;
        private System.Windows.Forms.Panel pnlsquareClick;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblstartingTime;
        private System.Windows.Forms.Label lblsuccessChance;
        private System.Windows.Forms.TextBox txtgameStats;
        private System.Windows.Forms.Panel pnlType;
        private System.Windows.Forms.Label lbltypeWord;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lbltypeText;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}