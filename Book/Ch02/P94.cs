using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class P94
    {
        static void Main94(string[] args)
        {

            // 증감 연산자의 후위 형태
            int number = 10;
            Console.WriteLine(number);
            Console.WriteLine(number++);
            Console.WriteLine(number--);
            Console.WriteLine(number);

            //증감 연산자의 전위 형태
            int number1 = 10;
            Console.WriteLine(number1);
            Console.WriteLine(++number1);
            Console.WriteLine(--number1);
            Console.WriteLine(number1);
        }
    }
}
