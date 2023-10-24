using System;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int input = int.Parse(Console.ReadLine());
            string[] numInput = Console.ReadLine().Split();

            int[] num = new int[input];
            
            for (int i = 0; i < input; i++)
            {
                num[i] = int.Parse(numInput[i]);
            }

            Array.Sort(num);

            Console.WriteLine($"{num[0]} {num[input-1]}");
        }
    }
}
