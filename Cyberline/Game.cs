using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cyberline
{
    public partial class Game : Form
    {
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);

        int GameType = 0;

        bool GameStart = false;
        int StartingTime = 3;
        int Time = 20;

        int successChance = 50;
        int Type = 0;

        int Clicks = 0;
        string Word = "";
        int wordsTyped = 0;

        Contract contract;
        Freelance freelance;

        public Game(int contractType)
        {
            InitializeComponent();
            Type = contractType;
        }

        private void gameEnd()
        {
            pnlsquareClick.Visible = false;
            pnlType.Visible = false;

            bool Success = false;

            int successCondition = 0;

            try
            {
                successCondition = r.Next(0, 101);
            }

            catch 
            {
                Success = true;
            }

            if (successCondition <= successChance)
            {
                Success = true;
            }

            else 
            {
                Success = false;
            }

            string gameStats = "";

            if (Success == true)
            {
                gameStats += "Success!" + Environment.NewLine;
            }

            else if (Success == false)
            {
                gameStats += "Hack failed!" + Environment.NewLine;
            }

            gameStats += "Chance of Success: " + successChance + "%" + Environment.NewLine;

            Computer computer = Application.OpenForms["Computer"] as Computer;

            if (Type == 3)
            {
                if (Success == true)
                {
                    Globals.Balance += contract.Payment;

                    gameStats += "Money Earned: $" + contract.Payment;
                }

                else if (Success == false && contract.BlackHat == true)
                {
                    int MoneyFined = (int)(contract.Payment / 3);
                    Globals.Balance -= MoneyFined;

                    gameStats += "Money Fined: $" + MoneyFined.ToString();
                }

                computer.Controls.Find("lblBalance", true)[0].Text = "$" + Globals.Balance.ToString();

                Globals.CurrentContract = null;

                computer.RefreshContracts();
            }

            else if (Type == 4)
            {
                if (Success == true)
                {
                    Globals.Balance += freelance.Payment;

                    gameStats += "Money Earned: $" + freelance.Payment;
                }

                else if (Success == false)
                {
                    int MoneyFined = (int)(freelance.Payment / 3);
                    Globals.Balance -= MoneyFined;

                    gameStats += "Money Fined: $" + MoneyFined.ToString();
                }

                computer.Controls.Find("lblBalance", true)[0].Text = "$" + Globals.Balance.ToString();

                Globals.CurrentFreelance = null;

                computer.RefreshFreelance();
            }

            else if (Type == 5)
            {
                if (Success == true)
                {
                    Globals.Balance += contract.Payment;

                    gameStats += "Money Earned: $" + contract.Payment;

                    //increase reputation and status in collective
                    Globals.Reputation += 3;
                    Globals.collectiveStatus++;
                }

                else if (Success == false && contract.BlackHat == true)
                {
                    int MoneyFined = (int)(freelance.Payment / 3);
                    Globals.Balance -= MoneyFined;

                    gameStats += "Money Fined: $" + MoneyFined.ToString();
                }

                computer.Controls.Find("lblBalance", true)[0].Text = "$" + Globals.Balance.ToString();

                //replace collective's contract
                List<int> skillsList = new List<int> { r.Next(1, 3), r.Next(0, 3), r.Next(0, 3), r.Next(0, 3) };
                var shuffledskillLevels = skillsList.OrderBy(a => Guid.NewGuid()).ToList();

                int Programming = shuffledskillLevels[0];
                int PasswordCracking = shuffledskillLevels[1];
                int DDOS = shuffledskillLevels[2];
                int IPSpoofing = shuffledskillLevels[3];

                int Payment = 1000;

                if (Globals.myCollective.BlackHat == false)
                {
                    Payment = 1000 + 100 * (Programming + PasswordCracking + DDOS + IPSpoofing);
                }

                else if (Globals.myCollective.BlackHat == true)
                {
                    Payment = 1200 + 100 * (Programming + PasswordCracking + DDOS + IPSpoofing);
                }

                int RandomContract = r.Next(0, 16);

                Globals.mycollectiveContract = new Contract(Globals.levelonecontractList[RandomContract], Payment, 1, Globals.myCollective.BlackHat, Programming, PasswordCracking, DDOS, IPSpoofing);
            }

            if (GameType == 0)
            {
                gameStats += Environment.NewLine + "Clicks: " + Clicks.ToString();
            }

            else if (GameType == 1)
            {
                gameStats += Environment.NewLine + "Words Typed: " + wordsTyped.ToString();
            }

            txtgameStats.Visible = true;
            txtgameStats.Text = gameStats;
            pauseToolStripMenuItem.Visible = false;
            closeToolStripMenuItem.Visible = true;

            computer.Show();
        }

        private void tmrgameTime_Tick(object sender, EventArgs e)
        {
            //gives player time to prepare before starting game
            if (StartingTime > 0)
            {
                StartingTime--;
                lblstartingTime.Text = StartingTime.ToString();
            }

            else if (StartingTime == 0)
            {
                if (GameType == 0)
                {
                    pnlsquareClick.Visible = true;
                }

                else if (GameType == 1)
                {
                    pnlType.Visible = true;

                    Word = File.ReadLines("words.txt").Skip(r.Next(0, 855) - 2).Take(1).First();
                    lbltypeWord.Text = Word;
                }

                lblstartingTime.Visible = false;

                GameStart = true;

                StartingTime = -1;
            }

            if (GameStart == true)
            {
                Time--;
                lblTime.Text = Time.ToString();
            }

            if (Time == 0)
            {
                GameStart = false;
                tmrgameTime.Enabled = false;
                gameEnd();
            }
        }

        private void lblClick_Click(object sender, EventArgs e)
        {
            successChance++;
            lblsuccessChance.Text = successChance.ToString() + "%";

            Clicks++;

            //randomize position of labels
            lblClick.Left = r.Next(pnlsquareClick.Left + 50, pnlsquareClick.Right - 50);
            lblClick.Top = r.Next(pnlsquareClick.Top + 50, pnlsquareClick.Bottom - 50);
        }

        private void Game_Load(object sender, EventArgs e)
        {
            GameType = r.Next(0, 2);

            //calculate starting chance of success
            if (Type == 3)
            {
                contract = Globals.CurrentContract;

                int Programming = 0;
                int PasswordCracking = 0;
                int DDOS = 0;
                int IPSpoofing = 0;

                foreach (var teammember in Globals.Team)
                {
                    if (teammember != null)
                    {
                        Programming += teammember.Programming;
                        PasswordCracking += teammember.PasswordCracking;
                        DDOS += teammember.DDOS;
                        IPSpoofing += teammember.IPSpoofing;
                    }
                }

                if (contract.Programming > 0)
                {
                    Programming -= contract.Programming;
                }

                if (contract.PasswordCracking > 0)
                {
                    PasswordCracking -= contract.PasswordCracking;
                }

                if (contract.DDOS > 0)
                {
                    DDOS -= contract.DDOS;
                }

                if (contract.IPSpoofing > 0)
                {
                    IPSpoofing -= contract.IPSpoofing;
                }

                successChance = 50 + 2 * (Programming + PasswordCracking + DDOS + IPSpoofing);

                lblsuccessChance.Text = successChance.ToString() + "%";
            }

            else if (Type == 4)
            {
                freelance = Globals.CurrentFreelance;

                int Programming = 0;
                int PasswordCracking = 0;

                foreach (var teammember in Globals.Team)
                {
                    if (teammember != null)
                    {
                        Programming += teammember.Programming;
                        PasswordCracking += teammember.PasswordCracking;
                    }
                }

                if (freelance.Programming > 0)
                {
                    Programming -= freelance.Programming;
                }

                if (freelance.PasswordCracking > 0)
                {
                    PasswordCracking -= freelance.PasswordCracking;
                }

                successChance = 60 + 2 * (Programming + PasswordCracking);

                lblsuccessChance.Text = successChance.ToString() + "%";
            }

            else if (Type == 5)
            {
                contract = Globals.mycollectiveContract;

                int Programming = 0;
                int PasswordCracking = 0;
                int DDOS = 0;
                int IPSpoofing = 0;

                foreach (var teammember in Globals.Team)
                {
                    if (teammember != null)
                    {
                        Programming += teammember.Programming;
                        PasswordCracking += teammember.PasswordCracking;
                        DDOS += teammember.DDOS;
                        IPSpoofing += teammember.IPSpoofing;
                    }
                }

                if (contract.Programming > 0)
                {
                    Programming -= contract.Programming;
                }

                if (contract.PasswordCracking > 0)
                {
                    PasswordCracking -= contract.PasswordCracking;
                }

                if (contract.DDOS > 0)
                {
                    DDOS -= contract.DDOS;
                }

                if (contract.IPSpoofing > 0)
                {
                    IPSpoofing -= contract.IPSpoofing;
                }

                successChance = 50 + 2 * (Programming + PasswordCracking + DDOS + IPSpoofing);

                lblsuccessChance.Text = successChance.ToString() + "%";
            }

            lblClick.Left = r.Next(pnlsquareClick.Left + 50, pnlsquareClick.Right - 50);
            lblClick.Top = r.Next(pnlsquareClick.Top + 50, pnlsquareClick.Bottom - 50);

            MessageBox.Show("The game will start in three seconds from when you hit OK.",
                "Game Starting",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            tmrgameTime.Enabled = true;
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tmrgameTime.Enabled == false)
            {
                if (GameStart == true)
                {
                    if (GameType == 0)
                    {
                        pnlsquareClick.Visible = true;
                    }

                    else if (GameType == 1)
                    {
                        pnlType.Visible = true;
                        txtType.Visible = true;
                        txtType.Focus();
                    }
                }

                pauseToolStripMenuItem.Text = "Pause";
                tmrgameTime.Enabled = true;
            }

            else if (tmrgameTime.Enabled == true)
            {
                pnlsquareClick.Visible = false;
                pnlType.Visible = false;
                txtType.Visible = false;

                pauseToolStripMenuItem.Text = "Resume";
                tmrgameTime.Enabled = false;
            }
        }

        private void lblClick_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void lblClick_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {
            string Input = txtType.Text.ToLower();

            //get new word
            if (Input == Word.ToLower())
            {
                successChance++;
                lblsuccessChance.Text = successChance.ToString() + "%";

                wordsTyped++;

                txtType.Clear();

                Word = File.ReadLines("words.txt").Skip(r.Next(0, 855) - 2).Take(1).First();
                lbltypeWord.Text = Word;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
