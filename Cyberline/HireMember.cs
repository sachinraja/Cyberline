using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cyberline
{
    public partial class HireMember : Form
    {
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);

        //list controls
        List<TextBox> memberTextboxList = new List<TextBox>();
        int membersCount = 0;

        int FormType;

        int ReplaceMemberPosition;

        public HireMember(int FormTypeHireorDisplay)
        {
            InitializeComponent();
            FormType = FormTypeHireorDisplay;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HireMember_FormClosing(object sender, FormClosingEventArgs e)
        {
            Team.HireMemberOpen = false;
        }

        public override void Refresh()
        {
            if (FormType == 0)
            {
                //generate team members to select from if there are none to choose from
                if (Globals.forHire.Count == 0)
                {
                    int RandomMemberAmount = r.Next(5, 10);

                    for (int i = 0; i < RandomMemberAmount; i++)
                    {
                        string FirstName = File.ReadLines("firstname.txt").Skip(r.Next(0, 8843) - 1).Take(1).First();
                        string LastName = File.ReadLines("lastname.txt").Skip(r.Next(0, 21986) - 1).Take(1).First();
                        string Name = FirstName + " " + LastName;

                        int Programming = r.Next(0, 3);
                        int PasswordCracking = r.Next(0, 3);
                        int DDOS = r.Next(0, 3);
                        int IPSpoofing = r.Next(0, 3);

                        //base 300 plus 25 for each level of each skill
                        int Pay = 300 + 25 * (Programming + PasswordCracking + DDOS + IPSpoofing);

                        Globals.forHire.Add(new TeamMember(Name, Pay, Programming, PasswordCracking, DDOS, IPSpoofing));
                    }
                }

                int TextBoxLeft = 20;
                int TextBoxTop = 30;

                for (int i = 0; i < Globals.forHire.Count; i++)
                {
                    string Description =
                        Globals.forHire[i].Name + Environment.NewLine +
                        "$" + Globals.forHire[i].Pay + Environment.NewLine +
                        "Programming: " + Globals.forHire[i].Programming + Environment.NewLine +
                        "Password Cracking: " + Globals.forHire[i].PasswordCracking + Environment.NewLine +
                        "DDOS: " + Globals.forHire[i].DDOS + Environment.NewLine +
                        "IP Spoofing: " + Globals.forHire[i].IPSpoofing;

                    memberTextboxList.Add(
                        new TextBox
                        {
                            ReadOnly = true,
                            Multiline = true,
                            Width = 150,
                            Height = 150,
                            Left = TextBoxLeft,
                            Top = TextBoxTop,
                            BackColor = Color.Green,
                            Text = Description,
                            Font = new Font("Microsoft YaHei", 10)
                        });

                    this.Controls.Add(memberTextboxList.ElementAt(membersCount));

                    memberTextboxList.ElementAt(membersCount).MouseEnter += Member_MouseEnter;
                    memberTextboxList.ElementAt(membersCount).MouseLeave += Member_MouseLeave;
                    memberTextboxList.ElementAt(membersCount).Click += Member_Click;

                    TextBoxLeft += 160;

                    membersCount++;

                    if (membersCount % 4 == 0)
                    {
                        TextBoxTop += 155;
                        TextBoxLeft = 20;
                    }
                }
            }

            if (FormType == 1)
            {
                int TextBoxLeft = 20;
                int TextBoxTop = 30;

                for (int i = 0; i < Globals.TeamReserves.Count; i++)
                {
                    string Description =
                        Globals.TeamReserves[i].Name + Environment.NewLine +
                        "Programming: " + Globals.TeamReserves[i].Programming + Environment.NewLine +
                        "Password Cracking: " + Globals.TeamReserves[i].PasswordCracking + Environment.NewLine +
                        "DDOS: " + Globals.TeamReserves[i].DDOS + Environment.NewLine +
                        "IP Spoofing: " + Globals.TeamReserves[i].IPSpoofing;

                    memberTextboxList.Add(
                        new TextBox
                        {
                            ReadOnly = true,
                            Multiline = true,
                            Width = 150,
                            Height = 150,
                            Left = TextBoxLeft,
                            Top = TextBoxTop,
                            BackColor = Color.Green,
                            Text = Description,
                            Font = new Font("Microsoft YaHei", 10)
                        });

                    this.Controls.Add(memberTextboxList.ElementAt(membersCount));

                    memberTextboxList.ElementAt(membersCount).MouseEnter += Member_MouseEnter;
                    memberTextboxList.ElementAt(membersCount).MouseLeave += Member_MouseLeave;
                    memberTextboxList.ElementAt(membersCount).Click += TeamAdd_Click;

                    TextBoxLeft += 160;

                    membersCount++;

                    if (membersCount % 4 == 0)
                    {
                        TextBoxTop += 155;
                        TextBoxLeft = 20;
                    }
                }
            }
        }

        private void HireMember_Load(object sender, EventArgs e)
        {
            if (FormType == 0)
            {
                this.Text = "Hire Member";
            }

            else if (FormType == 1)
            {
                this.Text = "Team Reserves";
            }

            Refresh();
        }
        private void Member_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Member_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        private void Member_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure you want to hire this team member?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            //hire member
            if (DialogResult == DialogResult.Yes)
            {
                int Position = memberTextboxList.IndexOf((TextBox)sender);
                Globals.TeamReserves.Add(Globals.forHire[Position]);

                Globals.Balance -= Globals.forHire[Position].Pay;
                Computer computer = Application.OpenForms["Computer"] as Computer;
                computer.Controls.Find("lblBalance", true)[0].Text = "$" + Globals.Balance.ToString();

                //reset people for hire once player buys a member
                Globals.forHire.Clear();

                foreach (var textbox in memberTextboxList)
                {
                    textbox.Dispose();
                }
                
                memberTextboxList.Clear();
                membersCount = 0;

                Refresh();
            }
        }

        private void TeamAdd_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure you want to add this person to your team?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            //add member to team
            if (DialogResult == DialogResult.Yes)
            {
                listBoxTeamReplace.Visible = true;

                MessageBox.Show("Which team member would you like to replace? Select your choice.", 
                    "Team Change", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Question);

                ReplaceMemberPosition = memberTextboxList.IndexOf((TextBox)sender);
            }
        }

        private void listBoxTeamReplace_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxTeamReplace.Visible = false;

            //move team member who was in that position to team reverses
            if (Globals.Team[listBoxTeamReplace.SelectedIndex] != null)
            {
                Globals.TeamReserves.Add(Globals.Team[listBoxTeamReplace.SelectedIndex]);
            }

            Globals.Team[listBoxTeamReplace.SelectedIndex] = Globals.TeamReserves[ReplaceMemberPosition];

            Globals.TeamReserves.RemoveAt(ReplaceMemberPosition);

            foreach (var textbox in memberTextboxList)
            {
                textbox.Dispose();
            }

            memberTextboxList.Clear();
            membersCount = 0;

            Refresh();

            string Skills = "";

            if (Globals.Team[listBoxTeamReplace.SelectedIndex].Programming > 0)
            {
                Skills += "Programming: " + Globals.Team[listBoxTeamReplace.SelectedIndex].Programming + Environment.NewLine;
            }

            if (Globals.Team[listBoxTeamReplace.SelectedIndex].PasswordCracking > 0)
            {
                Skills += "Password Cracking: " + Globals.Team[listBoxTeamReplace.SelectedIndex].PasswordCracking + Environment.NewLine;
            }

            if (Globals.Team[listBoxTeamReplace.SelectedIndex].DDOS > 0)
            {
                Skills += "DDOS: " + Globals.Team[listBoxTeamReplace.SelectedIndex].DDOS + Environment.NewLine;
            }

            if (Globals.Team[listBoxTeamReplace.SelectedIndex].IPSpoofing > 0)
            {
                Skills += "IP Spoofing: " + Globals.Team[listBoxTeamReplace.SelectedIndex].IPSpoofing;
            }

            //if the teams form is open then update it with the new information
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == "Team")
                {
                    Team team = Application.OpenForms["Team"] as Team;
                    team.Controls.Find("lblTeamMember" + listBoxTeamReplace.SelectedIndex.ToString(), true)[0].Text = Globals.Team[listBoxTeamReplace.SelectedIndex].Name;
                    team.Controls.Find("txtSkills" + listBoxTeamReplace.SelectedIndex.ToString(), true)[0].Text = Skills;
                }
            }
        }
    }
}
