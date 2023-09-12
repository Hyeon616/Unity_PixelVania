using System;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // 1330. 두 정수 A와 B가 주어졌을 때, A와 B를 비교하는 프로그램을 작성하시오.
            string[] input = Console.ReadLine().Split();
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            
            if (A > B)
            {
                Console.WriteLine(">");
            }
            else if (B > A)
            {
                Console.WriteLine("<");
            }
            else if(A == B)
            {
                Console.WriteLine("==");
            }
        }
    }
}
