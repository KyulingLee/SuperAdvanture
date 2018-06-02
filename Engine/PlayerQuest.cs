using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //사용자 퀘스트
    public class PlayerQuest
    {
        public Quest Details { get; set; }
        public bool IsCompleted { get; set; }

        //생성자
        public PlayerQuest(Quest details)
        {
            Details = details;
            IsCompleted = false;
        }
    }
}
