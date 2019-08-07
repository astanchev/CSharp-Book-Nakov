using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.EnterEvenNumberwithTextInput
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter even number: ");
                    int number = int.Parse(Console.ReadLine());
                    if (number % 2 == 0)
                    {
                        Console.WriteLine($"Even number entered: {number}");
                        break;
                    }
                    
                }
                catch 
                {
                    Console.WriteLine("The number is not even");
                    
                }
            }
        }
    }
}
