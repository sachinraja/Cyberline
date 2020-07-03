using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyberline
{
    public partial class CollectiveInfo : Form
    {
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);

        int CollectivePosition = 0;
        int Type = 0;

        public CollectiveInfo(int Position, int FormType)
        {
            InitializeComponent();
            CollectivePosition = Position;
            Type = FormType;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CollectiveInfo_Load(object sender, EventArgs e)
        {
            //display for any collective
            if (Type == 0)
            {
                lblName.Text = Globals.collectives[CollectivePosition].Name;

                if (Globals.collectives[CollectivePosition].BlackHat == false)
                {
                    lblType.Text = "White Hat";
                }

                else if (Globals.collectives[CollectivePosition].BlackHat == true)
                {
                    lblType.Text = "Black Hat";
                }

                lblSize.Text = "Size: " + Globals.collectives[CollectivePosition].Size.ToString();
                lblLevel.Text = "Level: " + Globals.collectives[CollectivePosition].Level.ToString();
                lblReputationRequirement.Text = "Reputation" + Environment.NewLine +
                    "Requirement: " + Globals.collectives[CollectivePosition].ReputationRequirement.ToString();
                picLogo.Image = Image.FromFile("collectiveLogo\\" + Globals.collectives[CollectivePosition].Name + ".png", true);
            }

            //display player's collective (with their collective's contract)
            else if (Type == 1)
            {
                btnJoin.Visible = false;
                btnContract.Visible = true;

                lblName.Text = Globals.myCollective.Name;

                if (Globals.myCollective.BlackHat == false)
                {
                    lblType.Text = "White Hat";
                }

                else if (Globals.myCollective.BlackHat == true)
                {
                    lblType.Text = "Black Hat";
                }

                lblSize.Text = "Size: " + Globals.myCollective.Size.ToString();
                lblLevel.Text = "Level: " + Globals.myCollective.Level.ToString();

                //display player's position within the collective
                string collectiveStatus = "";

                if (Globals.collectiveStatus == 0)
                {
                    collectiveStatus = "Junior Agent";
                }

                else if (Globals.collectiveStatus == 1)
                {
                    collectiveStatus = "Agent";
                }

                else if (Globals.collectiveStatus == 2)
                {
                    collectiveStatus = "Senior Agent";
                }

                else if (Globals.collectiveStatus == 3)
                {
                    collectiveStatus = "Agent Manager";
                }

                else if (Globals.collectiveStatus == 4)
                {
                    collectiveStatus = "Senior Agent Manager";
                }

                else if (Globals.collectiveStatus == 5)
                {
                    collectiveStatus = "Leader";
                }

                lblReputationRequirement.Text = collectiveStatus;

                picLogo.Image = Image.FromFile("collectiveLogo\\" + Globals.myCollective.Name + ".png", true);
            }    
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            bool CanJoin = false;

            if (Globals.collectives[CollectivePosition].BlackHat == false && Globals.Reputation > Globals.collectives[CollectivePosition].ReputationRequirement)
            {
                CanJoin = true;
            }

            if (Globals.collectives[CollectivePosition].BlackHat == true && Globals.Reputation < Globals.collectives[CollectivePosition].ReputationRequirement)
            {
                CanJoin = true;
            }

            if (CanJoin == true)
            {
                //player loses money if they are already in a collective
                DialogResult dialogResult = DialogResult.Yes;

                if (Globals.myCollective != null)
                {
                    dialogResult = MessageBox.Show("Warning! You will lose 20% of your balance and you will " +
                        "fall one rank by leaving your collective. Are you sure that you want to continue?",
                        "Warning",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                }

                if (dialogResult == DialogResult.Yes)
                {
                    Computer computer = Application.OpenForms["Computer"] as Computer;

                    if (Globals.myCollective != null)
                    {
                        
                        Globals.Balance = (int)(Globals.Balance * 0.8);

                        computer.Controls.Find("lblBalance", true)[0].Text = "$" + Globals.Balance.ToString();

                        if (Globals.collectiveStatus > 0)
                        {
                            Globals.collectiveStatus--;
                        }
                    }

                    Globals.myCollective = Globals.collectives[CollectivePosition];

                    Globals.collectives.RemoveAt(CollectivePosition);

                    //create contract for collective
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

                    if (Globals.collectives.Count == 0)
                    {
                        computer.RefreshCollectives();
                    }

                    else
                    {
                        computer.RefreshCollectivePictures();
                    }

                    this.Close();
                }
            }

            else
            {
                MessageBox.Show("You don't have enough reputation to join this collective.",
                    "Not Enough Reputation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            ContractInfo opencontractInfo = new ContractInfo(0, 5);
            opencontractInfo.Show();
        }
    }
}
