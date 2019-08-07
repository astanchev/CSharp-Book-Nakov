using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            int seats = rows * columns;

            if (projection == "premiere") Console.WriteLine("{0:f2} leva", seats*12);
            else if (projection == "normal") Console.WriteLine("{0:f2} leva", seats*7.50);
            else if (projection == "discount") Console.WriteLine("{0:f2} leva", seats*5);
        }
    }
}
