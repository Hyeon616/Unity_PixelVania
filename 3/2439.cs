using System;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2439. 첫째 줄에는 별 1개, 둘째 줄에는 별 2개, N번째 줄에는 별 N개를 찍는 문제

            // 하지만, 오른쪽을 기준으로 정렬한 별(예제 참고)을 출력하시오.

            int Star = int.Parse(Console.ReadLine());

            for (int i = 0; i < Star; i++)
            {
                // i에 1을 더해주지않으면 출력형식이 잘못되었습니다 라는 오류가 나온다.
                // 출력 시 공백이 더해져서 예제에서 한 칸이 더 들어가기때문에 발생함.
                for (int j = Star; j > i + 1; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
