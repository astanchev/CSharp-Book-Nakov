using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PointinFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool inRect1 = (x >= 2) && (x <= 12) && (y >= -3) && (y <= 1);
            bool inRect2 = (x >= 4) && (x <= 10) && (y >= -5) && (y <= 3);

            if (inRect1||inRect2)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
        }
    }
}
