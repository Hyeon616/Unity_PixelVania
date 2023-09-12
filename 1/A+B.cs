using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1000. 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
            string [] input = Console.ReadLine().Split();
          // Parse 로 string을 int로 변환
            Console.WriteLine(int.Parse(input[0]) + int.Parse(input[1]));
        }
    }
}
