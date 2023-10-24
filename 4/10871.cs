using System;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] input = Console.ReadLine().Split();
            string[] num = Console.ReadLine().Split();

            for (int i = 0; i < int.Parse(input[0]); i++)
            {
                if (int.Parse(num[i]) < int.Parse(input[1]))
                    Console.WriteLine(num[i]+"");
            }

        }
    }
}
