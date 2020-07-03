using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyberline
{
    public partial class Upgrade : Form
    {
        int Position = 0;

        int SkillMaximum = 10;

        int Programming = 0;
        int PasswordCracking = 0;
        int DDOS = 0;
        int IPSpoofing = 0;

        public Upgrade()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Upgrade_FormClosing(object sender, FormClosingEventArgs e)
        {
            Computer.UpgradeOpen = false;
        }

        private void listBoxteamSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Globals.Team[listBoxteamSelect.SelectedIndex] != null)
            {
                lblselectText.Visible = false;
                listBoxteamSelect.Visible = false;

                Position = listBoxteamSelect.SelectedIndex;

                lblmemberName.Text = Globals.Team[Position].Name;
                lblProgramming.Text = "Programming: " + Globals.Team[Position].Programming.ToString();
                lblPasswordCracking.Text = "Password Cracking: " + Globals.Team[Position].PasswordCracking.ToString();
                lblDDOS.Text = "DDOS: " + Globals.Team[Position].DDOS.ToString();
                lblIPSpoofing.Text = "IP Spoofing: " + Globals.Team[Position].IPSpoofing.ToString();

                pnlUpgrade.Visible = true;
            }
            
            else
            {
                MessageBox.Show("There is no team member in this slot.",
                    "No Team Member",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnprogrammingAdd_Click(object sender, EventArgs e)
        {
            if (Globals.Team[Position].Programming < SkillMaximum)
            {
                Programming++;
                lblProgramming.Text = "Programming: " + (Globals.Team[Position].Programming + Programming).ToString();
            }

            else
            {
                MessageBox.Show("You are already at the maximum for this skill.",
                    "Maximum",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnprogrammingSubtract_Click(object sender, EventArgs e)
        {
            if (Programming > 0)
            {
                Programming--;
                lblProgramming.Text = "Programming: " + (Globals.Team[Position].Programming + Programming).ToString();
            }

            else
            {
                MessageBox.Show("You cannot subtract from this skill.",
                    "Cannot Subtract",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnpasswordCrackingAdd_Click(object sender, EventArgs e)
        {
            if (Globals.Team[Position].PasswordCracking < SkillMaximum)
            {
                PasswordCracking++;
                lblPasswordCracking.Text = "Password Cracking: " + (Globals.Team[Position].PasswordCracking + PasswordCracking).ToString();
            }

            else
            {
                MessageBox.Show("You are already at the maximum for this skill.",
                    "Maximum",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnpasswordCrackingSubtract_Click(object sender, EventArgs e)
        {
            if (PasswordCracking > 0)
            {
                PasswordCracking--;
                lblPasswordCracking.Text = "Password Cracking: " + (Globals.Team[Position].PasswordCracking + PasswordCracking).ToString();
            }

            else
            {
                MessageBox.Show("You cannot subtract from this skill.",
                    "Cannot Subtract",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDDOSAdd_Click(object sender, EventArgs e)
        {
            if (Globals.Team[Position].DDOS < SkillMaximum)
            {
                DDOS++;
                lblDDOS.Text = "DDOS: " + (Globals.Team[Position].DDOS + DDOS).ToString();
            }

            else
            {
                MessageBox.Show("You are already at the maximum for this skill.",
                    "Maximum",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDDOSSubtract_Click(object sender, EventArgs e)
        {
            if (DDOS > 0)
            {
                DDOS--;
                lblDDOS.Text = "DDOS: " + (Globals.Team[Position].DDOS + DDOS).ToString();
            }

            else
            {
                MessageBox.Show("You cannot subtract from this skill.",
                    "Cannot Subtract",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnIPSpoofingAdd_Click(object sender, EventArgs e)
        {
            if (Globals.Team[Position].IPSpoofing < SkillMaximum)
            {
                IPSpoofing++;
                lblIPSpoofing.Text = "IP Spoofing: " + (Globals.Team[Position].IPSpoofing + IPSpoofing).ToString();
            }

            else
            {
                MessageBox.Show("You are already at the maximum for this skill.",
                    "Maximum",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnIPSpoofingSubtract_Click(object sender, EventArgs e)
        {
            if (IPSpoofing > 0)
            {
                IPSpoofing--;
                lblIPSpoofing.Text = "IP Spoofing: " + (Globals.Team[Position].IPSpoofing + IPSpoofing).ToString();
            }

            else
            {
                MessageBox.Show("You cannot subtract from this skill.",
                    "Cannot Subtract",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            int SkillAdd = Programming + PasswordCracking + DDOS + IPSpoofing;
            int Cost = 100 * SkillAdd;

            if (Globals.Balance < Cost)
            {
                MessageBox.Show("You cannot afford this. It will cost $" + Cost.ToString() +
                    " and you only have $" + Globals.Balance.ToString() + ".",
                    "Not Enough Money",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            else
            {
                DialogResult = MessageBox.Show("Are you sure you want buy these upgrades? It will cost $" +
                    Cost.ToString() + ".",
                    "Confirm Upgrade",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (DialogResult == DialogResult.Yes)
                {
                    //update values
                    Globals.Team[Position].Programming += Programming;
                    lblProgramming.Text = "Programming: " + Globals.Team[Position].Programming.ToString();
                    Globals.Team[Position].PasswordCracking += PasswordCracking;
                    lblPasswordCracking.Text = "Password Cracking: " + Globals.Team[Position].PasswordCracking.ToString();
                    Globals.Team[Position].DDOS += DDOS;
                    lblDDOS.Text = "DDOS: " + Globals.Team[Position].DDOS.ToString();
                    Globals.Team[Position].IPSpoofing += IPSpoofing;
                    lblIPSpoofing.Text = "IP Spoofing: " + Globals.Team[Position].IPSpoofing.ToString();

                    Globals.Balance -= Cost;

                    Computer computer = Application.OpenForms["Computer"] as Computer;
                    computer.Controls.Find("lblBalance", true)[0].Text = "$" + Globals.Balance.ToString();

                    Programming = 0;
                    PasswordCracking = 0;
                    DDOS = 0;
                    IPSpoofing = 0;
                }
            }
        }
    }
}
