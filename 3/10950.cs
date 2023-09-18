using System;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10950. 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                string[] s = Console.ReadLine().Split();
                int A = int.Parse(s[0]);
                int B = int.Parse(s[1]);

                Console.WriteLine(A + B);

            }
        }
    }
}
