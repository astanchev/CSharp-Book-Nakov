using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
          
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = k+1; j <=n+k ; j++)
                {
                    if (j>9)
                    {
                        Console.Write(j + " ");
                    }
                    else
                    {
                        Console.Write(j + "  ");
                    }
                    
                }
                k++;
                Console.WriteLine();
            }
        }
    }
}
