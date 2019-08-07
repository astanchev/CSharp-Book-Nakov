﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number>max)
                {
                    max = number;
                }
                if (number<min)
                {
                    min = number;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}
