using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class P183
    {
        static void Main184(string[] args)
        {
            string input = "감자 고구마 토마토";
            string[] inputs = input.Split(new char[] { ' ' }); // 문자열 자르기

            foreach (var item in inputs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
