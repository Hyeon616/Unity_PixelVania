using System;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10952. 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
            while (true)
            {
                string input = Console.ReadLine();

                string [] s = input.Split();

                int A = int.Parse(s[0]);
                int B = int.Parse(s[1]);

                if(A==0 && B==0)
                    break;

                Console.WriteLine($"{A+B}");

            }

        }
    }
}
