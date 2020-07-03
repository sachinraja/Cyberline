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
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Cyberline
{
    public partial class StartForm : Form
    {
        bool Exit = true;

        public StartForm()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            picBackground.Image = Image.FromFile("StartGif.gif", true);

            //wait for gif to finish before opening form
            await Task.Delay(700);

            //open computer form
            Globals.loadGame = false;
            Exit = false;
            this.Close();
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if the player exits intentionally the whole application closes
            if (Exit == true)
            {
                Application.Exit();
            }
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            //if the player has save data
            if (File.Exists("whitehatcontracts.xml"))
            {
                // Read data from XML
                //contracts
                using (FileStream fs = File.OpenRead("whitehatcontracts.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Contract>));
                    Globals.whitehatContracts = (List<Contract>)serializer.Deserialize(fs);
                }

                using (FileStream fs = File.OpenRead("blackhatcontracts.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Contract>));
                    Globals.blackhatContracts = (List<Contract>)serializer.Deserialize(fs);
                }

                if (File.Exists("currentcontract.xml"))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(Contract));
                    TextReader reader = new StreamReader("currentcontract.xml");
                    object obj = deserializer.Deserialize(reader);
                    Globals.CurrentContract = (Contract)obj;
                    reader.Close();
                }

                //freelance
                using (FileStream fs = File.OpenRead("freelancelist.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Freelance>));
                    Globals.freelanceList = (List<Freelance>)serializer.Deserialize(fs);
                }

                if (File.Exists("currentfreelance.xml"))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(Freelance));
                    TextReader reader = new StreamReader("currentfreelance.xml");
                    object obj = deserializer.Deserialize(reader);
                    Globals.CurrentFreelance = (Freelance)obj;
                    reader.Close();
                }

                //collective
                using (FileStream fs = File.OpenRead("collectives.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Collective>));
                    Globals.collectives = (List<Collective>)serializer.Deserialize(fs);
                }

                if (File.Exists("mycollective.xml"))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(Collective));
                    TextReader reader = new StreamReader("mycollective.xml");
                    object obj = deserializer.Deserialize(reader);
                    Globals.myCollective = (Collective)obj;
                    reader.Close();
                }

                if (File.Exists("mycollectivecontract.xml"))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(Contract));
                    TextReader reader = new StreamReader("mycollectivecontract.xml");
                    object obj = deserializer.Deserialize(reader);
                    Globals.mycollectiveContract = (Contract)obj;
                    reader.Close();
                }

                //team
                using (FileStream fs = File.OpenRead("team.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<TeamMember>));
                    Globals.Team = (List<TeamMember>)serializer.Deserialize(fs);
                }

                using (FileStream fs = File.OpenRead("teamreserves.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<TeamMember>));
                    Globals.TeamReserves = (List<TeamMember>)serializer.Deserialize(fs);
                }

                using (FileStream fs = File.OpenRead("forhire.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<TeamMember>));
                    Globals.forHire = (List<TeamMember>)serializer.Deserialize(fs);
                }

                picBackground.Image = Image.FromFile("StartGif.gif", true);

                //wait for gif to finish before opening form
                await Task.Delay(700);

                //open computer form
                Globals.loadGame = true;
                Exit = false;
                this.Close();
            }

            else
            {
                MessageBox.Show("There is no data to load from.", 
                    "No Save Data",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }

        }
    }
}
