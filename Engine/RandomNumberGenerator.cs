using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace Engine
{
    //랜덤 제너레이터
    public class RandomNumberGenerator
    {
        //랜덤 함수 내에서 자체적으로 생성 가능한 생성기가 있음.
        //그걸 이용해서 간단하게 처리.
        //-> 방법을 수정함.
        //보안에 있는 크립토그래피를 이용하면 좀 더 복잡하고 여러 경우의
        //랜덤 제너레이터가 이용 가능함.
        private static readonly RNGCryptoServiceProvider generator = new RNGCryptoServiceProvider();

        public static int NumberBetween(int minimumValue, int maximumValue)
        {
            byte[] randomNumber = new byte[1];

            generator.GetBytes(randomNumber);

            double asciiValueOfRandomCharacter = Convert.ToDouble(randomNumber[0]);

            //Math.Max랑 0.00000000001을 뺀 값을 사용하여 
            //"승수"가 항상 0.0에서 .99999999999 사이가 되도록 하였다.
            //그렇지 않으면 1이 될 수 있으므로 반올림 처리 하는 데 문제가 된다.
            double multiplier = Math.Max(0, (asciiValueOfRandomCharacter / 255d) - 0.00000000001d);

            // Math.Floor를 사용하여 반올림을 수행 할 수 있도록 범위에 하나를 추가한다.
            int range = maximumValue - minimumValue + 1;

            double randomValueInRange = Math.Floor(multiplier * range);

            return (int)(minimumValue + randomValueInRange);
        }
    }
}
