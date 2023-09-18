using System;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8393. n이 주어졌을 때, 1부터 n까지 합을 구하는 프로그램을 작성하시오.

            int i = int.Parse(Console.ReadLine());

            int temp = 0;

            for (int j = 0; j <= i; j++)
            {
                temp += j;

            }
            Console.WriteLine(temp);

        }
    }
}
