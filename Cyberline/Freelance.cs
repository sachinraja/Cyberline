using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Cyberline
{
    public class Freelance : ISerializable
    {
        public string Name { get; set; }
        public int Payment { get; set; }
        public int Programming { get; set; }
        public int PasswordCracking { get; set; }

        public Freelance() { }
        public Freelance(string PersonName = "No Name", int PaymentAmount = 0, int ProgrammingSkill = 0, int PasswordCrackingSkill = 0)
        {
            Name = PersonName;
            Payment = PaymentAmount;
            Programming = ProgrammingSkill;
            PasswordCracking = PasswordCrackingSkill;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Payment", Payment);
            info.AddValue("Programming", Programming);
            info.AddValue("PasswordCracking", PasswordCracking);
        }

        public Freelance(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Payment = (int)info.GetValue("Payment", typeof(int));
            Programming = (int)info.GetValue("Programming", typeof(int));
            PasswordCracking = (int)info.GetValue("PasswordCracking", typeof(int));
        }
    }
}
