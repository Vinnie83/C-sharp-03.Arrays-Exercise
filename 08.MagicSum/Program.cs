﻿namespace _08.MagicSum
{
    internal class Program
    {
        static void Main()
        {

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {

                    if (numbers[i] + numbers[j] == number)
                    {
                        Console.WriteLine(string.Join(" ", numbers[i], numbers[j]));
                    }
                }

            }
            

        }
    }
}