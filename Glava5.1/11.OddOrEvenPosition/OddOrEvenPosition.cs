using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.OddOrEvenPosition
{
    class OddOrEvenPosition
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMax = double.MinValue;
            double oddMin = double.MaxValue;
            double evenSum = 0;
            double evenMax = double.MinValue;
            double evenMin = double.MaxValue;
            string oddMaxString = string.Empty;
            string oddMinString = string.Empty;
            string evenMaxString = string.Empty;
            string evenMinString = string.Empty;


            for (double i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += number;
                    if (number < evenMin)
                    {
                        evenMin = number;
                        evenMinString = evenMin.ToString();
                    }
                    if (number > evenMax)
                    {
                        evenMax = number;
                        evenMaxString = evenMax.ToString();
                    }
                }
                else
                {
                    oddSum += number;
                    if (number < oddMin)
                    {
                        oddMin = number;
                        oddMinString = oddMin.ToString();
                    }
                    if (number > oddMax)
                    {
                        oddMax = number;
                        oddMaxString = oddMax.ToString();
                    }
                }
            }
            if (evenMaxString == string.Empty) evenMaxString = "No";
            if (evenMinString == string.Empty) evenMinString = "No";
            if (oddMaxString == string.Empty) oddMaxString = "No";
            if (oddMinString == string.Empty) oddMinString = "No";

            Console.WriteLine($"OddSum={oddSum}");
            Console.WriteLine($"OddMin={oddMinString}");
            Console.WriteLine($"OddMax={oddMaxString}");
            Console.WriteLine($"EvenSum={evenSum}");
            Console.WriteLine($"EvenMin={evenMinString}");
            Console.WriteLine($"EvenMax={evenMaxString}");            
        }
    }
}
