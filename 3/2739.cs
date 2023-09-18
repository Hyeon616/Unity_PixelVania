using System;

namespace BAEKJOON
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int A = int.Parse(Console.ReadLine());

           for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{A} * {i} = {A*i}");
            }

        }
    }
}
