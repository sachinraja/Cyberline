using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Cyberline
{
    public class TeamMember : ISerializable
    {
        public string Name { get; set; }
        public int Pay { get; set; }
        public int Programming { get; set; }
        public int PasswordCracking { get; set; }
        public int DDOS { get; set; }
        public int IPSpoofing { get; set; }

        public TeamMember() { }
        public TeamMember(string TeamMemberName = "No Name", int PaymentAmount = 0, int ProgrammingSkill = 0, int PasswordCrackingSkill = 0, int DDOSSkill = 0, int IPSpoofingSkill = 0)
        {
            Name = TeamMemberName;
            Pay = PaymentAmount;
            Programming = ProgrammingSkill;
            DDOS = DDOSSkill;
            PasswordCracking = PasswordCrackingSkill;
            IPSpoofing = IPSpoofingSkill;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Payment", Pay);
            info.AddValue("Programming", Programming);
            info.AddValue("PasswordCracking", PasswordCracking);
            info.AddValue("DDOS", DDOS);
            info.AddValue("IPSpoofing", IPSpoofing);
        }

        public TeamMember(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Pay = (int)info.GetValue("Pay", typeof(int));
            Programming = (int)info.GetValue("Programming", typeof(int));
            PasswordCracking = (int)info.GetValue("PasswordCracking", typeof(int));
            DDOS = (int)info.GetValue("DDOS", typeof(int));
            IPSpoofing = (int)info.GetValue("IPSpoofing", typeof(int));
        }
    }
}
