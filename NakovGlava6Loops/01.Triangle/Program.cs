using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (n<=9)
                    {
                        Console.Write(j + " ");
                    }
                    else
                    {
                        if (j<10)
                        {
                            Console.Write(j + "  ");
                        }
                        else
                        {
                            Console.Write(j + " ");
                        }
                        
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
