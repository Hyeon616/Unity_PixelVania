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
            // 11382.
            // 꼬마 정민이는 이제 A + B 정도는 쉽게 계산할 수 있다. 이제 A + B + C를 계산할 차례이다!
            // 첫 번째 줄에 A, B, C (1 ≤ A, B, C ≤ 10^12)이 공백을 사이에 두고 주어진다.
            string [] input1 = Console.ReadLine().Split();

            // int를 사용하면 문제의 범위보다 작아 overflowexception 발생
            long A = long.Parse(input1[0]);
            long B = long.Parse(input1[1]);
            long C = long.Parse(input1[2]);

            Console.WriteLine(A + B + C);

        }
    }
}
