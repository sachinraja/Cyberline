using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberline
{
    class Globals
    {
        public static int Balance = 500;
        public static int Reputation = 0;

        public static List<Contract> whitehatContracts = new List<Contract>();
        public static List<Contract> blackhatContracts = new List<Contract>();

        public static Contract CurrentContract;

        public static List<Freelance> freelanceList = new List<Freelance>();

        public static Freelance CurrentFreelance;

        public static List<Collective> collectives = new List<Collective>();

        public static Collective myCollective;
        public static Contract mycollectiveContract;
        public static int collectiveStatus = 0;

        public static List<TeamMember> Team = new List<TeamMember>() { null, null, null};
        public static List<TeamMember> TeamReserves = new List<TeamMember>();
        public static List<TeamMember> forHire = new List<TeamMember>();

        //consistent list of contracts
        public static string[] levelonecontractList = new string[16] {"VisualSocal", "Nascent Tech", "Infostrada", "Ergonomia",
            "Altran", "Symantec", "Cryptologi", "Citrix", "Alcatel", "Mercadeo", "Caspyan", "Skyver", "Konnect",
            "Texofer", "Amnesty", "Magnetis"};

        public static string[] collectiveList = new string[10] {"CyberOne", "Fyrewall", "Hij4cker", "Myriad", "Onyxetics",
            "Quantum", "Raize", "Shadow", "Tigook", "Vulturs"};

        public static bool loadGame = false;
    }
}
