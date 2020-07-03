using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyberline
{
    public partial class Reputation : Form
    {
        public Reputation()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reputation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Computer.ReputationOpen = false;
        }

        private void Reputation_Load(object sender, EventArgs e)
        {
            int currentReputation = Globals.Reputation;

            //gets 
            if (currentReputation <= 100 && currentReputation >= -100)
            {
                lblreputationSlider.Left -= (int)((currentReputation * 0.01) * lblblackHat.Width);
            }

            else
            {
                lblreputationSlider.Left -= (int)(Math.Sign(currentReputation) * lblblackHat.Width);
            }

            string reputationStatus = "";

            if (currentReputation == 0)
            {
                reputationStatus = "Beginner";
            }

            if (currentReputation > 0 && currentReputation <= 20)
            {
                reputationStatus = "Beginner White Hat";
            }

            else if (currentReputation > 20 && currentReputation <= 40)
            {
                reputationStatus = "Novice White Hat";
            }

            else if (currentReputation > 20 && currentReputation <= 40)
            {
                reputationStatus = "Novice White Hat";
            }

            else if (currentReputation > 40 && currentReputation <= 60)
            {
                reputationStatus = "Experienced White Hat";
            }

            else if (currentReputation > 60 && currentReputation <= 80)
            {
                reputationStatus = "Expert White Hat";
            }

            else if (currentReputation > 80 && currentReputation <= 100)
            {
                reputationStatus = "Elite White Hat";
            }

            else if (currentReputation > 100)
            {
                reputationStatus = "Master White Hat";
            }

            else if (currentReputation < 0 && currentReputation >= -20)
            {
                reputationStatus = "Beginner Black Hat";
            }

            else if (currentReputation < -20 && currentReputation >= -40)
            {
                reputationStatus = "Novice Black Hat";
            }

            else if (currentReputation < -40 && currentReputation >= -60)
            {
                reputationStatus = "Experienced Black Hat";
            }

            else if (currentReputation < -60 && currentReputation >= -80)
            {
                reputationStatus = "Expert Black Hat";
            }

            else if (currentReputation < -80 && currentReputation >= -100)
            {
                reputationStatus = "Elite Black Hat";
            }

            else if (currentReputation < -100)
            {
                reputationStatus = "Master Black Hat";

            }

            lblreputationStatus.Text = reputationStatus;
        }
    }
}
