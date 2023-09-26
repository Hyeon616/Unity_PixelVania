using System;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // 10951. 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
            while (true)
            {
              // 이전에 하던대로 배열로 ReadLine을 받을경우 Split으로 나누었을때 빈 배열을 반환하기때문에 null check를 할 수 없어 런타임 에러가 발생한다.
              
                string input = Console.ReadLine();

                if(input==null)
                    break;

                string [] s = input.Split();

                int A = int.Parse(s[0]);
                int B = int.Parse(s[1]);

                Console.WriteLine($"{A+B}");
            }

        }
    }
}
