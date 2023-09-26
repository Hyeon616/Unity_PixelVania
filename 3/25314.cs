using System;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 25314. 혜아가 N바이트 정수까지 저장할 수 있다고 생각하는 정수 자료형의 이름을 출력하여라.

            int N = int.Parse(Console.ReadLine());
            // N을 4로 나눈 몫만큼 반복하여 long 출력
            for (int i = 0; i < N/4 ; i++)
            {
                Console.WriteLine("long");

            }
            Console.WriteLine("int");
        }
    }
}
