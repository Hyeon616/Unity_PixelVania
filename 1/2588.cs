using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2588.
            //        472 ---- (1)
            //        385 ---- (2)
            //       2360 ---- (3)
            //      3776  ---- (4)
            //     1416   ---- (5)
            //     181720 ---- (6)
            // (1)과 (2)위치에 들어갈 세 자리 자연수가 주어질 때 (3), (4), (5), (6)위치에 들어갈 값을 구하는 프로그램을 작성하시오.
          
            int input1 = int.Parse(Console.ReadLine());
            string input2 = Console.ReadLine();

            // string을 배열로 자르면 char가 되기 때문에 ToString()으로 string 형식으로 변환
            Console.WriteLine(input1 * int.Parse(input2[2].ToString()));
            Console.WriteLine(input1 * int.Parse(input2[1].ToString()));
            Console.WriteLine(input1 * int.Parse(input2[0].ToString()));
            Console.WriteLine(input1 * int.Parse(input2));
            
        }
    }
}
