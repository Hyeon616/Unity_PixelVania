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
            string [] input = Console.ReadLine().Split();
            // float은 소수점 10^-7자리밖에 표현이 되지않음
            // 문제에서 요구하는 범위는 10^-9 자리수까지 표현하도록 되어있기때문에 double (혹은 decimal) 사용
            Console.WriteLine(double.Parse(input[0]) / double.Parse(input[1]));
        }
    }
}
