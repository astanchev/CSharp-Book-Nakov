using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int number = 0;
            while (true)
            {
                Console.Write("Enter even number: ");
                number = int.Parse(Console.ReadLine());
                if (number%2==0)
                {
                    Console.WriteLine($"Even number entered: {number}");
                    break;
                }
                Console.WriteLine("The number is not even");                
            }
        }
    }
}
