using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P96
    {
        static void Main96(string[] args)
        {

            // 증감 연산자 이해도 확인
            int number = 10;
            Console.WriteLine(number++);
            Console.WriteLine(++number);
            Console.WriteLine(number--);
            Console.WriteLine(--number);

            // 여러 줄로 나누어 적은 증감 연산자
            Console.WriteLine(number);
            number++;
            number++;
            Console.WriteLine(number);
            Console.WriteLine(number);
            number--;
            number--;
            Console.WriteLine(number);
        }
    }
}
