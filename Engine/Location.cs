using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //로케이션
    public class Location
    {
        //로케이션 기본 정보
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //로케이션 추가 정보
        //아이템 필요 여부
        public Item ItemRequiredToEnter { get; set; }
        //퀘스트 가능 여부
        public Quest QuestAvailableHere { get; set; }
        //몬스터 존재 여부
        public Monster MonsterLivingHere { get; set; }

        //4방향에 대한 로케이션
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; }

        //생성자
        // 추가 정보에 대한 기본 값을 설정하여 생성자 추가.
        public Location(int id, string name, string description, Item itemRequiredToEnter = null, Quest questAvailableHere = null, Monster monsterLivingHere = null)
        {
            //기본 정보 설정
            ID = id;
            Name = name;
            Description = description;

            //추가 정보에 대한 생성자 설정
            //기본은 생성 함수에서 이미 null로 만들었다만, 값이 들어오면 들어온 값으로 처리한다.
            ItemRequiredToEnter = itemRequiredToEnter;
            QuestAvailableHere = questAvailableHere;
            MonsterLivingHere = monsterLivingHere;
        }
    }
}
