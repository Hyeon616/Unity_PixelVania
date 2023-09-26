using System;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 11022. 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.

            int Case = int.Parse(Console.ReadLine());

            for (int i = 0; i < Case; i++)
            {
                string[] s = Console.ReadLine().Split();
                int A = int.Parse(s[0]);
                int B = int.Parse(s[1]);

                Console.WriteLine($"Case #{i+1}: {A} + {B} = {A+B}");
            }
        }
    }
}
