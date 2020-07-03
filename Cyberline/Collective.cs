using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Cyberline
{
    public class Collective : ISerializable
    {
        public string Name { get; set; }
        public bool BlackHat { get; set; }
        public int Size { get; set; }
        public int Level { get; set; }
        public int ReputationRequirement { get; set; }

        public Collective() { }
        public Collective(string collectiveName = "No Name", bool IsBlackHatcollective = false, int collectiveSize = 0, int collectiveLevel = 0, int collectiveRequirement = 0)
        {
            Name = collectiveName;
            BlackHat = IsBlackHatcollective;
            Size = collectiveSize;
            Level = collectiveLevel;
            ReputationRequirement = collectiveRequirement;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("BlackHat", BlackHat);
            info.AddValue("Size", Size);
            info.AddValue("Level", Level);
            info.AddValue("ReputationRequirement", ReputationRequirement);
        }

        public Collective(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            BlackHat = (bool)info.GetValue("BlackHat", typeof(bool));
            Size = (int)info.GetValue("Size", typeof(int));
            Level = (int)info.GetValue("Level", typeof(int));
            ReputationRequirement = (int)info.GetValue("ReputationRequirement", typeof(int));
        }
    }
}
