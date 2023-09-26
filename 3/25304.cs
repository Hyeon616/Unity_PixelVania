using System;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 25304. 구매한 물건의 가격과 개수로 계산한 총 금액이 영수증에 적힌 총 금액과 일치하는지 검사해보자.

            int cost = int.Parse(Console.ReadLine());
            int item = int.Parse(Console.ReadLine());
            int itemCost = 0;

            for (int i = 0; i < item; i++)
            {
                string[] s = Console.ReadLine().Split();
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);
                // 입력을 받고 총 가격에 합산
                itemCost += a * b;
            }

            if (itemCost == cost)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

        }
    }
}
