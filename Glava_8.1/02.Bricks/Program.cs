﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            int bricks = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int course = workers * capacity;
            double numberCourses = Math.Ceiling((double)bricks / course);

            Console.WriteLine(numberCourses);


        }
    }
}
