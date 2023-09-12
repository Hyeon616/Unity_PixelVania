using System;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // 9498. 시험 점수를 입력받아 90 ~ 100점은 A, 80 ~ 89점은 B, 70 ~ 79점은 C, 60 ~ 69점은 D, 나머지 점수는 F를 출력하는 프로그램을 작성하시오.
            int input = int.Parse(Console.ReadLine());

            if (input > 89)
            {
                Console.WriteLine("A");
            }
            else if (input > 79)
            {
                Console.WriteLine("B");
            }
            else if (input > 69)
            {
                Console.WriteLine("C");
            }
            else if (input > 59)
            {
                Console.WriteLine("D");
            }
            else if (input <= 59)
            {
                Console.WriteLine("F");
            }
        }
    }
}
