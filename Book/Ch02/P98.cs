using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P98
    {
        static void Main98(string[] args)
        {
            // 변수를 선언합니다.
            int _int = 273;
            long _long = 522731033265;
            float _float = 52.273F;
            char _char = '글';
            string _string = "문자열";

            // 출력합니다.
            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_char.GetType());
            Console.WriteLine(_string.GetType());
        }
    }
}
