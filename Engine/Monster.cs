using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //몬스터
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }

        //최대 데미지
        public int MaximumDamage { get; set; }

        //보상
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
    }
}
