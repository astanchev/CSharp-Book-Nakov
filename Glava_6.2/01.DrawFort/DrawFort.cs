using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DrawFort
{
    class DrawFort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int colSize = n / 2;
            int midSize = 2 * n - 2 * colSize - 4;
            string top = "/" + new string('^', colSize) + "\\" + new string('_', midSize) + 
                "/" + new string('^', colSize) + "\\";
            string middle = "|" + new string(' ', 2 * n - 2) + "|";
            string penultimate = "|" + new string(' ', colSize+1) + new string('_', midSize) + 
                new string(' ', colSize + 1) + "|";
            string bottom = "\\" + new string('_', colSize) + "/" + new string(' ', midSize) + 
                "\\" + new string('_', colSize) + "/";
            Console.WriteLine(top);
            for (int i = 1; i <= n-3; i++)
            {
                Console.WriteLine(middle);
            }
            Console.WriteLine(penultimate);            
            Console.WriteLine(bottom);
        }
    }
}
