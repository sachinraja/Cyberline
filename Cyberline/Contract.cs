using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Cyberline
{
    [Serializable()]
    public class Contract : ISerializable
    {
        //create fields
        public string Name { get; set; }
        public int Payment { get; set; }
        public int Level { get; set; }
        public bool BlackHat { get; set; }
        public int Programming { get; set; }
        public int PasswordCracking { get; set; }
        public int DDOS { get; set; }
        public int IPSpoofing { get; set; }

        public Contract() { }
        //create a class constructor for the Contract class
        public Contract(string ContractName = "No Name", int PaymentAmount = 0, int DifficultyLevel = 0, bool IsBlackHat = false, int ProgrammingSkill = 0, int PasswordCrackingSkill = 0, int DDOSSkill = 0, int IPSpoofingSkill = 0)
        {
            //set the initial value for fields
            Name = ContractName;
            Payment = PaymentAmount;
            Level = DifficultyLevel;
            BlackHat = IsBlackHat;
            Programming = ProgrammingSkill;
            DDOS = DDOSSkill;
            PasswordCracking = PasswordCrackingSkill;
            IPSpoofing = IPSpoofingSkill;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Payment", Payment);
            info.AddValue("Level", Level);
            info.AddValue("BlackHat", BlackHat);
            info.AddValue("Programming", Programming);
            info.AddValue("PasswordCracking", PasswordCracking);
            info.AddValue("DDOS", DDOS);
            info.AddValue("IPSpoofing", IPSpoofing);
        }

        public Contract(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Payment = (int)info.GetValue("Payment", typeof(int));
            Level = (int)info.GetValue("Level", typeof(int));
            BlackHat = (bool)info.GetValue("BlackHat", typeof(bool));
            Programming = (int)info.GetValue("Programming", typeof(int));
            PasswordCracking = (int)info.GetValue("PasswordCracking", typeof(int));
            DDOS = (int)info.GetValue("DDOS", typeof(int));
            IPSpoofing = (int)info.GetValue("IPSpoofing", typeof(int));
        }
    }
}
