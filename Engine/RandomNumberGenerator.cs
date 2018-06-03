using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //랜덤 제너레이터
    public class RandomNumberGenerator
    {
        //랜덤 함수 내에서 자체적으로 생성 가능한 생성기가 있음.
        //그걸 이용해서 간단하게 처리.
        private static Random generator = new Random();

        public static int NumberBetween(int minimumValue, int maximumValue)
        {
            return generator.Next(minimumValue, maximumValue + 1);
        }
    }
}
