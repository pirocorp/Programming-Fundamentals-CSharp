﻿using System;


namespace PrintingTriangle
{
    class PrintingTriangle
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        static void PrintTriangle(int n)
        {
            for (int line = 1; line <= n; line++)
                PrintLine(1, line);

            for (int line = n - 1; line >= 1; line--)
                PrintLine(1, line);
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

    }
}
