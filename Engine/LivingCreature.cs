using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //생물 (사용자, 몬스터)를 하나로 묶는 부모 클래스
    public class LivingCreature
    {
        //Hit Points
        public int CurrentHitPoints { get; set; }
        public int MaximumHitPoints { get; set; }

        //생성자
        public LivingCreature(int currentHitPoints, int maximumHitPoints)
        {
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints;
        }
    }
}
