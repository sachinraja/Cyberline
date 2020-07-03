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
    public partial class Team : Form
    {
        public static bool HireMemberOpen = false;

        public Team()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Team_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Globals.Team.Count; i++)
            {
                if (Globals.Team[i] != null)
                {
                    this.Controls.Find("lblTeamMember" + i.ToString(), true)[0].Text = Globals.Team[i].Name;

                    string Skills = "";

                    if (Globals.Team[i].Programming > 0)
                    {
                        Skills += "Programming: " + Globals.Team[i].Programming + Environment.NewLine;
                    }

                    if (Globals.Team[i].PasswordCracking > 0)
                    {
                        Skills += "Password Cracking: " + Globals.Team[i].PasswordCracking + Environment.NewLine;
                    }

                    if (Globals.Team[i].DDOS > 0)
                    {
                        Skills += "DDOS: " + Globals.Team[i].DDOS + Environment.NewLine;
                    }

                    if (Globals.Team[i].IPSpoofing > 0)
                    {
                        Skills += "IP Spoofing: " + Globals.Team[i].IPSpoofing;
                    }

                    this.Controls.Find("txtSkills" + i.ToString(), true)[0].Text = Skills;
                }
            }
        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            if (HireMemberOpen == false)
            {
                HireMember openhireMember = new HireMember(0);
                openhireMember.Show();
                HireMemberOpen = true;
            }
        }

        private void Team_FormClosing(object sender, FormClosingEventArgs e)
        {
            Computer.TeamOpen = false;
        }

        private void btnTeamReverses_Click(object sender, EventArgs e)
        {
            if (HireMemberOpen == false)
            {
                HireMember openhireMember = new HireMember(1);
                openhireMember.Show();
                HireMemberOpen = true;
            }
        }
    }
}
