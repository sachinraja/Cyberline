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
using System.Xml.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Cyberline
{
    public partial class Computer : Form
    {
        //random numbers code
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);

        bool MenuOpen = false;
        public static bool TeamOpen = false;
        public static bool ReputationOpen = false;
        public static bool UpgradeOpen = false;

        //list controls
        List<PictureBox> contractPictureList = new List<PictureBox>();
        int contractCount = 0;

        List<Label> freelanceLabelList = new List<Label>();
        int freelanceCount = 0;

        List<PictureBox> collectivePictureList = new List<PictureBox>();
        int collectiveCount = 0;

        //current contract
        public static int ContractPosition;
        public static int ContractType;

        public Computer()
        {
            InitializeComponent();
        }

        private void picMenuButton_Click(object sender, EventArgs e)
        {
            //if the menu isn't open then display the menu buttons
            if (MenuOpen == false)
            {
                btncurrentContract.Visible = true;
                btncurrentFreelance.Visible = true;
                btnmyCollective.Visible = true;
                btnContracts.Visible = true;
                btnFreelance.Visible = true;
                btnTeam.Visible = true;
                btnReputation.Visible = true;
                btnCollectives.Visible = true;
                btnUpgrade.Visible = true;
                MenuOpen = true;
            }

            //if the menu is open then close it on the click of the button
            else if (MenuOpen == true)
            {
                btncurrentContract.Visible = false;
                btncurrentFreelance.Visible = false;
                btnmyCollective.Visible = false;
                btnContracts.Visible = false;
                btnFreelance.Visible = false;
                btnTeam.Visible = false;
                btnReputation.Visible = false;
                btnCollectives.Visible = false;
                btnUpgrade.Visible = false;
                MenuOpen = false;
            }   
        }

        private void Click_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Click_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            pnlContracts.Visible = true;
            pnlFreelance.Visible = false;
            pnlCollective.Visible = false;
        }

        private void btnFreelance_Click(object sender, EventArgs e)
        {
            pnlContracts.Visible = false;
            pnlFreelance.Visible = true;
            pnlCollective.Visible = false;
        }

        private void btnCollectives_Click(object sender, EventArgs e)
        {

            pnlCollective.Visible = false;
            pnlFreelance.Visible = false;
            pnlCollective.Visible = true;
        }

        private void btncurrentContract_Click(object sender, EventArgs e)
        {
            if (Globals.CurrentContract != null)
            {
                //open contract info showing current contract
                ContractInfo opencontractInfo = new ContractInfo(0, 3);
                opencontractInfo.Show();
            }

            else
            {
                MessageBox.Show("You don't currently have a contract.",
                    "No Current Contract",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btncurrentFreelance_Click(object sender, EventArgs e)
        {
            if (Globals.CurrentFreelance != null)
            {
                ContractInfo opencontractInfo = new ContractInfo(0, 4);
                opencontractInfo.Show();
            }

            else
            {
                MessageBox.Show("You don't currently have a freelance contract.",
                    "No Current Freelance Contract",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnmyCollective_Click(object sender, EventArgs e)
        {
            if (Globals.myCollective != null)
            {
                CollectiveInfo opencollectiveInfo = new CollectiveInfo(0, 1);
                opencollectiveInfo.Show();
            }

            else
            {
                MessageBox.Show("You are not currently in a collective.",
                    "No Collective",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnTeam_Click(object sender, EventArgs e)
        {
            if (TeamOpen == false)
            {
                Team openteam = new Team();
                openteam.Show();
                TeamOpen = true;
            }
        }

        private void btnReputation_Click(object sender, EventArgs e)
        {
            if (ReputationOpen == false)
            {
                Reputation openReputation = new Reputation();
                openReputation.Show();

                ReputationOpen = true;
            }
        }

        public void RefreshContractPictures()
        {
            //clear previous controls
            foreach (var picturebox in contractPictureList)
            {
                picturebox.Dispose();
            }

            contractPictureList.Clear();
            contractCount = 0;

            //change list depending on radiobutton
            List<Contract> contracts = Globals.whitehatContracts;

            if (radwhiteHat.Checked == true)
            {
                contracts = Globals.whitehatContracts;
            }

            else if (radblackHat.Checked == true)
            {
                contracts = Globals.blackhatContracts;
            }

            int PictureBoxLeft = pnlContracts.Left;
            int PictureBoxTop = pnlContracts.Top;

            for (int i = 0; i < contracts.Count; i++)
            {
                //dynamically add contract pictureboxes to form
                contractPictureList.Add(new PictureBox
                {
                    Width = 75,
                    Height = 75,
                    Left = PictureBoxLeft,
                    Top = PictureBoxTop,
                    Image = Image.FromFile("contractLogo\\level" + contracts[i].Level.ToString() + "\\" + contracts[i].Name + ".png", true),
                    SizeMode = PictureBoxSizeMode.StretchImage
                });

                pnlContracts.Controls.Add(contractPictureList.ElementAt(contractCount));

                //add event handlers
                contractPictureList.ElementAt(contractCount).MouseEnter += Click_MouseEnter;
                contractPictureList.ElementAt(contractCount).MouseLeave += Click_MouseLeave;
                contractPictureList.ElementAt(contractCount).Click += Contracts_Click;


                //format for next picturebox
                PictureBoxLeft += 85;

                contractCount++;

                //go down after a row of four pictureboxes
                if (contractCount % 4 == 0)
                {
                    PictureBoxTop += 80;
                    PictureBoxLeft = pnlContracts.Left;
                }
            }
        }

        public void RefreshContracts()
        {
            Globals.whitehatContracts.Clear();
            Globals.blackhatContracts.Clear();

            //clear previous controls
            foreach (var picturebox in contractPictureList)
            {
                picturebox.Dispose();
            }

            contractPictureList.Clear();
            contractCount = 0;

            radwhiteHat.Checked = true;

            var leveloneshuffledwhitehatContracts = Globals.levelonecontractList.OrderBy(a => Guid.NewGuid()).ToList();
            var leveloneshuffledblackhatContracts = Globals.levelonecontractList.OrderBy(a => Guid.NewGuid()).ToList();

            //create contracts
            int RandomContractAmount = r.Next(5, 11);

            //white hat
            for (int i = 0; i < RandomContractAmount; i++)
            {
                //ensures that at least one skill is recommended
                List<int> skillsList = new List<int> {r.Next(1, 3), r.Next(0, 3), r.Next(0, 3), r.Next(0, 3)};
                var shuffledskillLevels = skillsList.OrderBy(a => Guid.NewGuid()).ToList();

                int Programming = shuffledskillLevels[0];
                int PasswordCracking = shuffledskillLevels[1];
                int DDOS = shuffledskillLevels[2];
                int IPSpoofing = shuffledskillLevels[3];

                //calculates payment based on the amount of skill recommended
                int Payment = 1000 + 100 * (Programming + PasswordCracking + DDOS + IPSpoofing);

                Globals.whitehatContracts.Add(new Contract(leveloneshuffledwhitehatContracts[i], Payment, 1, false, Programming, PasswordCracking, DDOS, IPSpoofing));
            }

            //black hat
            for (int j = 0; j < RandomContractAmount; j++)
            {
                List<int> skillsList = new List<int> {r.Next(1, 3), r.Next(0, 3), r.Next(0, 3), r.Next(0, 3)};
                var shuffledskillLevels = skillsList.OrderBy(a => Guid.NewGuid()).ToList();

                int Programming = shuffledskillLevels[0];
                int PasswordCracking = shuffledskillLevels[1];
                int DDOS = shuffledskillLevels[2];
                int IPSpoofing = shuffledskillLevels[3];

                int Payment = 1200 + 100 * (Programming + PasswordCracking + DDOS + IPSpoofing);

                Globals.blackhatContracts.Add(new Contract(leveloneshuffledblackhatContracts[j], Payment, 1, true, Programming, PasswordCracking, DDOS, IPSpoofing));
            }

            //set box location for each company picture
            int PictureBoxLeft = pnlContracts.Left;
            int PictureBoxTop = pnlContracts.Top;

            for (int i = 0; i < RandomContractAmount; i++)
            {
                //dynamically add contract pictureboxes to form
                contractPictureList.Add(new PictureBox
                {
                    Width = 75,
                    Height = 75,
                    Left = PictureBoxLeft,
                    Top = PictureBoxTop,
                    Image = Image.FromFile("contractLogo\\level" + Globals.whitehatContracts[i].Level.ToString() + "\\" + Globals.whitehatContracts[i].Name + ".png", true),
                    SizeMode = PictureBoxSizeMode.StretchImage
                });

                pnlContracts.Controls.Add(contractPictureList.ElementAt(contractCount));

                //add event handlers
                contractPictureList.ElementAt(contractCount).MouseEnter += Click_MouseEnter;
                contractPictureList.ElementAt(contractCount).MouseLeave += Click_MouseLeave;
                contractPictureList.ElementAt(contractCount).Click += Contracts_Click;


                //format for next picturebox
                PictureBoxLeft += 85;

                contractCount++;

                //go down after a row of four pictureboxes
                if (contractCount % 4 == 0)
                {
                    PictureBoxTop += 80;
                    PictureBoxLeft = pnlContracts.Left;
                }
            }
        }

        public void RefreshFreelancePictures()
        {
            foreach (var label in freelanceLabelList)
            {
                label.Dispose();
            }

            freelanceLabelList.Clear();
            freelanceCount = 0;

            int LabelLeft = pnlFreelance.Left;
            int LabelTop = pnlFreelance.Top;

            for (int i = 0; i < Globals.freelanceList.Count; i++)
            {
                freelanceLabelList.Add(
                    new Label
                    {
                        Width = 100,
                        Height = 50,
                        Left = LabelLeft,
                        Top = LabelTop,
                        BackColor = Color.Green,
                        Text = Globals.freelanceList[i].Name,
                        Font = new Font("Microsoft YaHei", 10)
                    });

                pnlFreelance.Controls.Add(freelanceLabelList.ElementAt(freelanceCount));

                freelanceLabelList.ElementAt(freelanceCount).MouseEnter += Click_MouseEnter;
                freelanceLabelList.ElementAt(freelanceCount).MouseLeave += Click_MouseLeave;
                freelanceLabelList.ElementAt(freelanceCount).Click += Freelance_Click;

                LabelLeft += 110;

                freelanceCount++;

                if (freelanceCount % 3 == 0)
                {
                    LabelTop += 55;
                    LabelLeft = pnlFreelance.Left;
                }
            }
        }

        public void RefreshFreelance()
        {
            Globals.freelanceList.Clear();

            foreach (var label in freelanceLabelList)
            {
                label.Dispose();
            }

            freelanceLabelList.Clear();
            freelanceCount = 0;

            //generate random amount of names
            int RandomNameAmount = r.Next(10, 19);

            for (int i = 0; i < RandomNameAmount; i++)
            {
                string FirstName = File.ReadLines("firstname.txt").Skip(r.Next(0, 8843) - 2).Take(1).First();
                string LastName = File.ReadLines("lastname.txt").Skip(r.Next(0, 21986) - 2).Take(1).First();
                string Name = FirstName + " " + LastName;

                List<int> skillsList = new List<int> {r.Next(1, 3), r.Next(0, 3)};
                var shuffledskillLevels = skillsList.OrderBy(a => Guid.NewGuid()).ToList();

                int Programming = shuffledskillLevels[0];
                int PasswordCracking = shuffledskillLevels[1];

                int Payment = 500 + 100 * (Programming + PasswordCracking);

                Globals.freelanceList.Add(new Freelance(Name, Payment, Programming, PasswordCracking));
            }

            //set box location for each company picture
            int LabelLeft = pnlFreelance.Left;
            int LabelTop = pnlFreelance.Top;

            for (int i = 0; i < RandomNameAmount; i++)
            {
                freelanceLabelList.Add(
                    new Label
                    {
                        Width = 100,
                        Height = 50,
                        Left = LabelLeft,
                        Top = LabelTop,
                        BackColor = Color.Green,
                        Text = Globals.freelanceList[i].Name,
                        Font = new Font("Microsoft YaHei", 10)
                    });

                pnlFreelance.Controls.Add(freelanceLabelList.ElementAt(freelanceCount));

                freelanceLabelList.ElementAt(freelanceCount).MouseEnter += Click_MouseEnter;
                freelanceLabelList.ElementAt(freelanceCount).MouseLeave += Click_MouseLeave;
                freelanceLabelList.ElementAt(freelanceCount).Click += Freelance_Click;

                LabelLeft += 110;

                freelanceCount++;

                if (freelanceCount % 3 == 0)
                {
                    LabelTop += 55;
                    LabelLeft = pnlFreelance.Left;
                }
            }
        }

        public void RefreshCollectivePictures()
        {
            foreach (var picturebox in collectivePictureList)
            {
                picturebox.Dispose();
            }

            collectivePictureList.Clear();
            collectiveCount = 0;

            int PictureBoxLeft = pnlCollective.Left;
            int PictureBoxTop = pnlCollective.Top;

            for (int i = 0; i < Globals.collectives.Count; i++)
            {
                //dynamically add contract pictureboxes to form
                collectivePictureList.Add(new PictureBox
                {
                    Width = 75,
                    Height = 75,
                    Left = PictureBoxLeft,
                    Top = PictureBoxTop,
                    Image = Image.FromFile("collectiveLogo\\" + Globals.collectives[i].Name + ".png", true),
                    SizeMode = PictureBoxSizeMode.StretchImage
                });

                pnlCollective.Controls.Add(collectivePictureList.ElementAt(collectiveCount));

                //add event handlers
                collectivePictureList.ElementAt(collectiveCount).MouseEnter += Click_MouseEnter;
                collectivePictureList.ElementAt(collectiveCount).MouseLeave += Click_MouseLeave;
                collectivePictureList.ElementAt(collectiveCount).Click += Collectives_Click;


                //format for next picturebox
                PictureBoxLeft += 85;

                collectiveCount++;

                //go down after a row of four pictureboxes
                if (collectiveCount % 4 == 0)
                {
                    PictureBoxTop += 80;
                    PictureBoxLeft = pnlContracts.Left;
                }
            }
        }

        public void RefreshCollectives()
        {
            //clear previous controls
            foreach (var picturebox in collectivePictureList)
            {
                picturebox.Dispose();
            }

            collectivePictureList.Clear();
            collectiveCount = 0;

            var shuffledCollectives = Globals.collectiveList.OrderBy(a => Guid.NewGuid()).ToList();

            int RandomCollectiveAmount = r.Next(5, 11);

            for (int i = 0; i < RandomCollectiveAmount; i++)
            {
                int IsBlackHat = r.Next(0, 2);
                bool BlackHat = false;

                if (IsBlackHat == 0)
                {
                    BlackHat = false;
                }

                else if (IsBlackHat == 1)
                {
                    BlackHat = true;
                }

                int Level = r.Next(1, 4);

                int CollectiveSize = 0;

                if (Level == 1)
                {
                    CollectiveSize = r.Next(5, 15);
                }

                else if (Level == 2)
                {
                    CollectiveSize = r.Next(15, 25);
                }

                else if (Level == 3)
                {
                    CollectiveSize = r.Next(25, 40);
                }

                int ReputationSign = 1;

                if (BlackHat == true)
                {
                    ReputationSign = -1;
                }

                int ReputationRequirement = (ReputationSign * 10 * Level) + (ReputationSign * CollectiveSize / 2);

                Globals.collectives.Add(new Collective(shuffledCollectives[i], BlackHat, CollectiveSize, Level, ReputationRequirement));
            }

            //set box location for each company picture
            int PictureBoxLeft = pnlCollective.Left;
            int PictureBoxTop = pnlCollective.Top;

            for (int i = 0; i < RandomCollectiveAmount; i++)
            {
                //dynamically add contract pictureboxes to form
                collectivePictureList.Add(new PictureBox
                {
                    Width = 75,
                    Height = 75,
                    Left = PictureBoxLeft,
                    Top = PictureBoxTop,
                    Image = Image.FromFile("collectiveLogo\\" + Globals.collectives[i].Name + ".png", true),
                    SizeMode = PictureBoxSizeMode.StretchImage
                });

                pnlCollective.Controls.Add(collectivePictureList.ElementAt(collectiveCount));

                //add event handlers
                collectivePictureList.ElementAt(collectiveCount).MouseEnter += Click_MouseEnter;
                collectivePictureList.ElementAt(collectiveCount).MouseLeave += Click_MouseLeave;
                collectivePictureList.ElementAt(collectiveCount).Click += Collectives_Click;


                //format for next picturebox
                PictureBoxLeft += 85;

                collectiveCount++;

                //go down after a row of four pictureboxes
                if (collectiveCount % 4 == 0)
                {
                    PictureBoxTop += 80;
                    PictureBoxLeft = pnlContracts.Left;
                }
            }
        }

        private void Computer_Load(object sender, EventArgs e)
        {
            if (Globals.loadGame == false)
            {
                RefreshContracts();
                RefreshFreelance();
                RefreshCollectives();

                string FirstName = File.ReadLines("firstname.txt").Skip(r.Next(0, 8843) - 1).Take(1).First();
                string LastName = File.ReadLines("lastname.txt").Skip(r.Next(0, 21986) - 1).Take(1).First();
                string Name = FirstName + " " + LastName;

                int Programming = r.Next(0, 3);
                int PasswordCracking = r.Next(0, 3);
                int DDOS = r.Next(0, 3);
                int IPSpoofing = r.Next(0, 3);

                //base 300 plus 25 for each level of each skill
                int Pay = 300 + 25 * (Programming + PasswordCracking + DDOS + IPSpoofing);

                Globals.Team[0] = new TeamMember(Name, Pay, Programming, PasswordCracking, DDOS, IPSpoofing);
            }

            else if (Globals.loadGame == true)
            {
                RefreshContractPictures();
                RefreshFreelancePictures();
                RefreshCollectivePictures();
            }
        }

        private void Contracts_Click(object sender, EventArgs e)
        {
            int ContractTypeNumber = 0;

            if (radwhiteHat.Checked == true)
            {
                ContractTypeNumber = 0;
            }

            else if (radblackHat.Checked == true)
            {
                ContractTypeNumber = 1;
            }

            //get position by searching for sender in list
            ContractInfo opencontractInfo = new ContractInfo(contractPictureList.IndexOf((PictureBox)sender), ContractTypeNumber);
            opencontractInfo.Show();
        }

        private void Freelance_Click(object sender, EventArgs e)
        {
            ContractInfo opencontractInfo = new ContractInfo(freelanceLabelList.IndexOf((Label)sender), 2);
            opencontractInfo.Show();
        }

        private void Collectives_Click(object sender, EventArgs e)
        {
            CollectiveInfo opencollectiveInfo = new CollectiveInfo(collectivePictureList.IndexOf((PictureBox)sender), 0);
            opencollectiveInfo.Show();
        }

        private void Hat_CheckedChanged(object sender, EventArgs e)
        {
            if (sender.GetType().Name == "RadioButton")
            {
                //clear previous controls
                foreach (var picturebox in contractPictureList)
                {
                    picturebox.Dispose();
                }

                contractPictureList.Clear();
                contractCount = 0;

                //change list depending on radiobutton
                List<Contract> contracts = Globals.whitehatContracts;

                if (radwhiteHat.Checked == true)
                {
                    contracts = Globals.whitehatContracts;
                }

                else if (radblackHat.Checked == true)
                {
                    contracts = Globals.blackhatContracts;
                }

                int PictureBoxLeft = pnlContracts.Left;
                int PictureBoxTop = pnlContracts.Top;

                for (int i = 0; i < contracts.Count; i++)
                {
                    //dynamically add contract pictureboxes to form
                    contractPictureList.Add(new PictureBox
                    {
                        Width = 75,
                        Height = 75,
                        Left = PictureBoxLeft,
                        Top = PictureBoxTop,
                        Image = Image.FromFile("contractLogo\\level" + contracts[i].Level.ToString() + "\\" + contracts[i].Name + ".png", true),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    });

                    pnlContracts.Controls.Add(contractPictureList.ElementAt(contractCount));

                    //add event handlers
                    contractPictureList.ElementAt(contractCount).MouseEnter += Click_MouseEnter;
                    contractPictureList.ElementAt(contractCount).MouseLeave += Click_MouseLeave;
                    contractPictureList.ElementAt(contractCount).Click += Contracts_Click;


                    //format for next picturebox
                    PictureBoxLeft += 85;

                    contractCount++;

                    //go down after a row of four pictureboxes
                    if (contractCount % 4 == 0)
                    {
                        PictureBoxTop += 80;
                        PictureBoxLeft = pnlContracts.Left;
                    }
                }
            }
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            if (UpgradeOpen == false)
            {
                Upgrade openupgrade = new Upgrade();
                openupgrade.Show();

                UpgradeOpen = true;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //load data into XML
            //contracts
            using (Stream fs = new FileStream("whitehatcontracts.xml",
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Contract>));
                serializer.Serialize(fs, Globals.whitehatContracts);
            }

            using (Stream fs = new FileStream("blackhatcontracts.xml",
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Contract>));
                serializer.Serialize(fs, Globals.blackhatContracts);
            }

            if (Globals.CurrentContract != null)
            {
                // Serialize the object data to a file
                using (TextWriter tw = new StreamWriter("currentcontract.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Contract));
                    serializer.Serialize(tw, Globals.CurrentContract);
                }
            }

            //freelance
            using (Stream fs = new FileStream("freelancelist.xml",
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Freelance>));
                serializer.Serialize(fs, Globals.freelanceList);
            }

            if (Globals.CurrentFreelance != null)
            {
                using (TextWriter tw = new StreamWriter("currentfreelance.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Freelance));
                    serializer.Serialize(tw, Globals.CurrentFreelance);
                }
            }

            //collectives
            using (Stream fs = new FileStream("collectives.xml",
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Collective>));
                serializer.Serialize(fs, Globals.collectives);
            }

            if (Globals.myCollective != null)
            {
                using (TextWriter tw = new StreamWriter("mycollective.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Collective));
                    serializer.Serialize(tw, Globals.myCollective);
                }
            }

            if (Globals.mycollectiveContract != null)
            {
                using (TextWriter tw = new StreamWriter("mycollectivecontract.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Contract));
                    serializer.Serialize(tw, Globals.mycollectiveContract);
                }
            }

            //team
            using (Stream fs = new FileStream("team.xml",
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<TeamMember>));
                serializer.Serialize(fs, Globals.Team);
            }

            using (Stream fs = new FileStream("teamreserves.xml",
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<TeamMember>));
                serializer.Serialize(fs, Globals.TeamReserves);
            }

            using (Stream fs = new FileStream("forhire.xml",
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<TeamMember>));
                serializer.Serialize(fs, Globals.forHire);
            }

            MessageBox.Show("Saved!",
                "Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
