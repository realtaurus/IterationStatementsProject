using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            int num = 0;
            do
            {
                num++;
                numbers.Add(num);

            } while (num < 100);

            while (num < 200)
            {
                num++;
                numbers.Add(num);
            }
            Console.WriteLine("Increase:");
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine("Decrease:");
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}