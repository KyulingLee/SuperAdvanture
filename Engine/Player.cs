using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //플레이어
    public class Player : LivingCreature
    {
        //Gold
        public int Gold { get; set; }

        //Exp
        public int ExperiencePoints { get; set; }

        //Level
        public int Level { get; set; }

        //사용자 인벤토리
        public List<InventoryItem> Inventory { get; set; }

        //사용자 퀘스트
        public List<PlayerQuest> Quests { get; set; }

        //자식 생성자
        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level) : base (currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;

            //인벤토리, 퀘스트 생성
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();
        }
    }
}
