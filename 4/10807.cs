ing System;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            int input = int.Parse(Console.ReadLine());

            string[] num = Console.ReadLine().Split();

            int findNum = int.Parse(Console.ReadLine());


            for (int i = 0; i < input; i++)
            {
                if (findNum == int.Parse(num[i]))
                    count++;
            }
            
            Console.WriteLine(count);
        }
    }
}
