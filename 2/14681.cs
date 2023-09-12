using System;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // 14681. 점의 좌표를 입력받아 그 점이 어느 사분면에 속하는지 알아내는 프로그램을 작성하시오. 
          
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            if (A > 0 && B > 0)
            {
                Console.WriteLine("1");
            }
            else if (A < 0 && B > 0)
            {
                Console.WriteLine("2");
            }
            else if (A < 0 && B < 0)
            {
                Console.WriteLine("3");
            }
            else if (A > 0 && B < 0)
            {
                Console.WriteLine("4");
            }
        }
    }
}
