using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            int velocity = int.Parse(Console.ReadLine());
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());


            double firstTime = time1 / 60.0;
            double secondTime = time2 / 60.0;
            double thirdTime = time3 / 60.0;

            double distance = firstTime * velocity + secondTime * 1.1 * velocity + thirdTime * 0.95 * (1.1*velocity);

            Console.WriteLine($"{distance:f2}");
        }
    }
}
