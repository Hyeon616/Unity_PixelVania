using System;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // 2480.
          // 1에서부터 6까지의 눈을 가진 3개의 주사위를 던져서 다음과 같은 규칙에 따라 상금을 받는 게임이 있다. 
          // 같은 눈이 3개가 나오면 10,000원+(같은 눈)×1,000원의 상금을 받게 된다. 
          // 같은 눈이 2개만 나오는 경우에는 1,000원+(같은 눈)×100원의 상금을 받게 된다. 
          // 모두 다른 눈이 나오는 경우에는 (그 중 가장 큰 눈)×100원의 상금을 받게 된다.  
          // 3개 주사위의 나온 눈이 주어질 때, 상금을 계산하는 프로그램을 작성 하시오.
          
            string[] input = Console.ReadLine().Split();
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int C = int.Parse(input[2]);

            if (A == B && B == C)
            {
                Console.WriteLine(10000 + A * 1000);
            }

            else if (A == B)
            {
                Console.WriteLine(1000 + A * 100);
            }
            else if (B == C)
            {
                Console.WriteLine(1000 + B * 100);
            }
            else if (A == C)
            {
                Console.WriteLine(1000 + A * 100);
            }

            else
            {
                if (A > B && A > C)
                    Console.WriteLine(A * 100);
                else if(B > A && B > C)
                    Console.WriteLine(B * 100);
                else if (C > A && C > B)
                    Console.WriteLine(C * 100);
            }
        }
    }
}
