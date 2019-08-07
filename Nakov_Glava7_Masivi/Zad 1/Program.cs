using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] twenty = new int[20];

            for (int i = 0; i < twenty.Length; i++)
            {
                twenty[i] = i * 5;
                Console.Write(twenty[i] + " ");
            }
                       
            Console.WriteLine();
        }
    }
}
