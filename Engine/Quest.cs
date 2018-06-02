using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //퀘스트
    public class Quest
    {
        //퀘스트 기본 정보
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }

        //아이템 보상에 대해서 추가
        public Item RewardItem { get; set; }

        //생성자
        public Quest(int id, string name, string descriptopn, int rewardExperiencePoints, int rewardGold)
        {
            ID = id;
            Name = name;
            Description = descriptopn;
            RewardExperiencePoints = RewardExperiencePoints;
            RewardGold = rewardGold;
        }
    }
}
