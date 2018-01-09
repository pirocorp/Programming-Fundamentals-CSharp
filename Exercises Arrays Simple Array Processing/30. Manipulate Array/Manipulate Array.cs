﻿using System;

namespace _30.Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimeterList = { ' ' };
            string[] array = Console.ReadLine()
                .Split(delimeterList, StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(Console.ReadLine());
            string[] command;

            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine().Split(delimeterList, StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {
                    case "Reverse":
                        Reverse(array);
                        break;
                    case "Distinct":
                        Distinct(array);
                        break;
                    case "Replace":
                        Replace(array, int.Parse(command[1]), command[2]);
                        break;
                }
            }

            string result = String.Join(" ", array);
            array = result.Split(delimeterList, StringSplitOptions.RemoveEmptyEntries);
            result = String.Join(", ", array);
            Console.WriteLine(result);
        }

        private static void Replace(string[] array, int index, string element)
        {
            array[index] = element;
        }

        private static void Distinct(string[] array)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j] && j != i)
                    {
                        array[j] = string.Empty;
                    }
                }
            }
        }

        private static void Reverse(string[] array)
        {
            string currentElement = string.Empty;
            int n = array.Length / 2;
            for (int i = 0; i < n; i++)
            {
                currentElement = array[i];
                array[i] = array[array.Length - (1 + i)];
                array[array.Length - (1 + i)] = currentElement;
            }
        }
    }
}
