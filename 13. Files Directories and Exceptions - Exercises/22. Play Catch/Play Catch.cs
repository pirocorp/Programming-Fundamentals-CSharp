﻿namespace _22.Play_Catch
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PlayCatch
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int exceptionsCounter = 0;

            while (exceptionsCounter < 3)
            {
                var input = Console.ReadLine().Split(' ');
                var command = input[0];

                try
                {
                    switch (command)
                    {
                        case "Replace":
                            var index = int.Parse(input[1]);
                            var element = int.Parse(input[2]);
                            numbers.RemoveAt(index);
                            numbers.Insert(index, element);
                            break;

                        case "Print":
                            int startIndex = int.Parse(input[1]);
                            int endIndex = int.Parse(input[2]);
                            var listToPrint = new List<int>();

                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                listToPrint.Add(numbers[i]);
                            }

                            Console.WriteLine(string.Join(", ", listToPrint));
                            break;

                        case "Show":
                            var indexForShowing = int.Parse(input[1]);
                            Console.WriteLine(numbers[indexForShowing]);
                            break;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    exceptionsCounter++;
                    Console.WriteLine($"The index does not exist!");
                }
                catch (FormatException)
                {
                    exceptionsCounter++;
                    Console.WriteLine("The variable is not in the correct format!");
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
