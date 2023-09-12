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
            // 10869. 두 자연수 A와 B가 주어진다. 이때, A+B, A-B, A*B, A/B(몫), A%B(나머지)를 출력하는 프로그램을 작성하시오. 
            string [] input = Console.ReadLine().Split();
            Console.WriteLine(int.Parse(input[0]) + int.Parse(input[1]));
            Console.WriteLine(int.Parse(input[0]) - int.Parse(input[1]));
            Console.WriteLine(int.Parse(input[0]) * int.Parse(input[1]));
            Console.WriteLine(int.Parse(input[0]) / int.Parse(input[1]));
            Console.WriteLine(int.Parse(input[0]) % int.Parse(input[1]));
        }
    }
}
