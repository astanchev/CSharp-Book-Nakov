using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool firstArrayIsShorter = false;            
            
            char[] arrA = new char[5] { 'a', 'b', 'c', 'd', 'e'};
            char[] arrB = new char[4] { 'a', 'b', 'c', 'd'};
            
            if (arrA.Length<arrB.Length)
            {
                firstArrayIsShorter = true;
                
            }

            int lenght = firstArrayIsShorter? arrA.Length : arrB.Length;

            for (int i = 0; i < lenght; i++)
            {
                if (arrA[i] < arrB[i])
                {
                    Console.WriteLine("The first Array is earlier.");
                    return;
                }
                else if (arrA[i] > arrB[i])
                {
                    Console.WriteLine("The second Array is earlier.");
                    return;
                }
            }

            if (firstArrayIsShorter)
            {
                Console.WriteLine("The first Array is earlier.");
            }
            else if(arrA.Length > arrB.Length)
            {
                Console.WriteLine("The second Array is earlier.");
            }
            else
            {
                Console.WriteLine("The arrays are equal.");
            }
        }
    }
}
