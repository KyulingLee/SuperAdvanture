using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player
    {
        //Hit Points
        public int CurrentHitPoints { get; set; }
        public int MaximumHitPoints { get; set; }

        //Gold
        public int Gold { get; set; }

        //Exp
        public int ExperiencePoints { get; set; }

        //Level
        public int Level { get; set; }
    }
}
