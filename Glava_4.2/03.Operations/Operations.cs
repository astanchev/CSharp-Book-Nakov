using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Operations
{
    class Operations
    {
        static void Main(string[] args)
        {
            decimal n1 = decimal.Parse(Console.ReadLine());
            decimal n2 = decimal.Parse(Console.ReadLine());
            string nOperator = Console.ReadLine();

            decimal result = 0;
            string output = string.Empty;

            if (n2.Equals(0) && (nOperator.Equals("/") || nOperator.Equals("%")))
            {
                output = string.Format("Cannot divide {0} by zero", n1);
            }
            else if (nOperator.Equals("/"))
            {
                output = string.Format("{0} {1} {2} = {3:f2}", n1, nOperator, n2, (n1 / n2));
            }
            else if (nOperator.Equals("%"))
            {
                output = string.Format("{0} {1} {2} = {3}", n1, nOperator, n2, (n1 % n2));
            }
            else
            {
                if (nOperator.Equals("+"))
                {
                    result = n1 + n2;
                }
                else if (nOperator.Equals("-"))
                {
                    result = n1 - n2;
                }
                else if (nOperator.Equals("*"))
                {
                    result = n1 * n2;
                }
                string resultType = (result % 2 == 0) ? "even" : "odd";
                output = string.Format("{0} {1} {2} = {3} - {4}", n1, nOperator, n2, result, resultType);
            }

            Console.WriteLine(output);
        }
    }
}
