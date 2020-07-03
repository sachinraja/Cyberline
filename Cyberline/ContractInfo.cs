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
    public partial class ContractInfo : Form
    {
        int ContractPosition;
        int ContractType;
        Contract contract;
        Freelance freelance;

        List<Contract> contracts = Globals.whitehatContracts;

        public ContractInfo(int Position, int WhichContract)
        {
            InitializeComponent();
            ContractPosition = Position;
            ContractType = WhichContract;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ContractInfo_Load(object sender, EventArgs e)
        {
            //any contract
            if (ContractType == 0 || ContractType == 1)
            {
                if (ContractType == 0)
                {
                    contracts = Globals.whitehatContracts;
                }

                else if (ContractType == 1)
                {
                    contracts = Globals.blackhatContracts;
                }

                //fill fields with contract info
                lblName.Text = contracts[ContractPosition].Name;
                lblPayment.Text = "$" + contracts[ContractPosition].Payment.ToString();
                lblLevel.Text = "Level: " + contracts[ContractPosition].Level.ToString();
                picLogo.Image = Image.FromFile("contractLogo\\level" + contracts[ContractPosition].Level.ToString() + "\\" + contracts[ContractPosition].Name + ".png", true);

                string Skills = "";

                if (contracts[ContractPosition].Programming > 0)
                {
                    Skills += "Programming: " + contracts[ContractPosition].Programming + Environment.NewLine;
                }

                if (contracts[ContractPosition].PasswordCracking > 0)
                {
                    Skills += "Password Cracking: " + contracts[ContractPosition].PasswordCracking + Environment.NewLine;
                }

                if (contracts[ContractPosition].DDOS > 0)
                {
                    Skills += "DDOS: " + contracts[ContractPosition].DDOS + Environment.NewLine;
                }

                if (contracts[ContractPosition].IPSpoofing > 0)
                {
                    Skills += "IP Spoofing: " + contracts[ContractPosition].IPSpoofing;
                }
                
                txtSkills.Text = Skills;

            }

            //any freelance
            else if (ContractType == 2)
            {
                //remove unnecessary controls
                lblLevel.Visible = false;
                picLogo.Visible = false;

                lblName.Text = Globals.freelanceList[ContractPosition].Name;
                lblPayment.Text = "$" + Globals.freelanceList[ContractPosition].Payment.ToString();

                string Skills = "";

                if (Globals.freelanceList[ContractPosition].Programming > 0)
                {
                    Skills += "Programming: " + Globals.freelanceList[ContractPosition].Programming + Environment.NewLine;
                }

                if (Globals.freelanceList[ContractPosition].PasswordCracking > 0)
                {
                    Skills += "Password Cracking: " + Globals.freelanceList[ContractPosition].PasswordCracking;
                }

                txtSkills.Text += Skills;
            }

            //current contract
            else if (ContractType == 3)
            {
                btnAccept.Visible = false;
                btnHack.Visible = true;

                contract = Globals.CurrentContract;

                lblName.Text = contract.Name;
                lblPayment.Text = "$" + contract.Payment.ToString();
                lblLevel.Text = "Level: " + contract.Level.ToString();
                picLogo.Image = Image.FromFile("contractLogo\\level" + contract.Level.ToString() + "\\" + contract.Name + ".png", true);

                string Skills = "";

                if (contract.Programming > 0)
                {
                    Skills += "Programming: " + contract.Programming + Environment.NewLine;
                }

                if (contract.PasswordCracking > 0)
                {
                    Skills += "Password Cracking: " + contract.PasswordCracking + Environment.NewLine;
                }

                if (contract.DDOS > 0)
                {
                    Skills += "DDOS: " + contract.DDOS + Environment.NewLine;
                }

                if (contract.IPSpoofing > 0)
                {
                    Skills += "IP Spoofing: " + contract.IPSpoofing;
                }

                txtSkills.Text = Skills;
            }

            //current freelance
            else if (ContractType == 4)
            {
                btnAccept.Visible = false;
                btnHack.Visible = true;
                lblLevel.Visible = false;
                picLogo.Visible = false;

                freelance = Globals.CurrentFreelance;

                lblName.Text = freelance.Name;
                lblPayment.Text = "$" + freelance.Payment.ToString();

                string Skills = "";

                if (freelance.Programming > 0)
                {
                    Skills += "Programming: " + freelance.Programming + Environment.NewLine;
                }

                if (freelance.PasswordCracking > 0)
                {
                    Skills += "Password Cracking: " + freelance.PasswordCracking;
                }

                txtSkills.Text += Skills;
            }

            //collective's contract
            else if (ContractType == 5)
            {
                btnAccept.Visible = false;
                btnHack.Visible = true;

                contract = Globals.mycollectiveContract;
 
                lblName.Text = contract.Name;
                lblPayment.Text = "$" + contract.Payment.ToString();
                lblLevel.Text = "Level: " + contract.Level.ToString();
                picLogo.Image = Image.FromFile("contractLogo\\level" + contract.Level.ToString() + "\\" + contract.Name + ".png", true);

                string Skills = "";

                if (contract.Programming > 0)
                {
                    Skills += "Programming: " + contract.Programming + Environment.NewLine;
                }

                if (contract.PasswordCracking > 0)
                {
                    Skills += "Password Cracking: " + contract.PasswordCracking + Environment.NewLine;
                }

                if (contract.DDOS > 0)
                {
                    Skills += "DDOS: " + contract.DDOS + Environment.NewLine;
                }

                if (contract.IPSpoofing > 0)
                {
                    Skills += "IP Spoofing: " + contract.IPSpoofing;
                }

                txtSkills.Text = Skills;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Computer computer = Application.OpenForms["Computer"] as Computer;

            if (ContractType == 0 || ContractType == 1)
            {
                DialogResult = MessageBox.Show("Are you sure you want to accept this contract? " +
                    "This will remove your current contract.",
                    "Accept",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (DialogResult == DialogResult.Yes)
                {
                    Globals.CurrentContract = contracts[ContractPosition];
                    
                    //removes contract that player accepted from list
                    if (ContractType == 0)
                    {
                        Globals.whitehatContracts.RemoveAt(ContractPosition);
                    }

                    else if (ContractType == 1)
                    {
                        Globals.blackhatContracts.RemoveAt(ContractPosition);
                    }

                    computer.RefreshContractPictures();

                    this.Close();
                }
            }

            if (ContractType == 2)
            {
                DialogResult = MessageBox.Show("Are you sure you want to accept this freelance contract? " +
                                    "This will reset your current freelance contract.",
                                    "Accept",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                if (DialogResult == DialogResult.Yes)
                {
                    Globals.CurrentFreelance = Globals.freelanceList[ContractPosition];

                    Globals.freelanceList.RemoveAt(ContractPosition);

                    computer.RefreshFreelancePictures();

                    this.Close();
                }
            }
        }

        private void btnHack_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure that you want to hack this with your team?",
                "Hack",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                Game openGame = new Game(ContractType);
                openGame.Show();

                Computer computer = Application.OpenForms["Computer"] as Computer;
                computer.Hide();

                //close collective info form if it is open
                FormCollection fc = Application.OpenForms;

                foreach (Form frm in fc)
                {
                    if (frm.Name == "CollectiveInfo")
                    {
                        frm.Close();
                        break;
                    }
                }

                this.Close();
            }
        }
    }
}
