using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad04
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                if (i == 0) Console.Write("Diamonds: ");
                if (i == 1) Console.Write("Spades: ");
                if (i == 2) Console.Write("Hearts: ");
                if (i == 3) Console.Write("Clubs: ");
                for (int j = 1; j < 14; j++)
                {
                    if (j>1 && j < 11) Console.Write(j+" ");
                    else if (j == 11) Console.Write("J ");
                    else if (j == 12) Console.Write("Q ");
                    else if (j == 13) Console.Write("K ");
                    else if (j == 1) Console.Write("A ");
                }
                Console.WriteLine();
            }
        }
    }
}
