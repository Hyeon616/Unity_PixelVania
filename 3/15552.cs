using System;
using System.Text;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 15552. 각 테스트케이스마다 A+B를 한 줄에 하나씩 순서대로 출력한다.

            StringBuilder sb = new StringBuilder();

            int T = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < T; i++)
            {
                string[] s = Console.ReadLine().Split();
                sb.Append(int.Parse(s[0]) + int.Parse(s[1]) + "\n");

            }
            Console.WriteLine(sb.ToString());
        }
    }
}
