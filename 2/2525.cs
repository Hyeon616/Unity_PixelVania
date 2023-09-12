using System;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // 2525. 훈제오리구이를 시작하는 시각과 오븐구이를 하는 데 필요한 시간이 분단위로 주어졌을 때, 오븐구이가 끝나는 시각을 계산하는 프로그램을 작성하시오.
          
            string[] input = Console.ReadLine().Split();
          // 시작시간
            int A = int.Parse(input[0]); 
            int B = int.Parse(input[1]);
          // 필요한 시간 (분)
            int Temp = int.Parse(Console.ReadLine());

            int H = A;
            int M = B + Temp;

            if (M > 59)
            {
              // 60이 넘는값은 반복해서 60 미만이 되도록 실행
                while(M > 59)
                {
                    H++;
                    M = M - 60;
                }
            }

            if (H > 23)
            {
                H = H -24;
            }

            Console.WriteLine(H + " " + M);

        }
    }
}
