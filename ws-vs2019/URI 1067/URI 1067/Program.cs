﻿using System;

namespace URI_1067
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            X = int.Parse(Console.ReadLine());


            for (int i = 1; i <=X; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
