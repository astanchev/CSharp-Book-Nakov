using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            int sumRight = 0;

            for (int j = 0; j < n; j++)
            {
                int leftNumber = int.Parse(Console.ReadLine());
                sumLeft += leftNumber;
            }
            for (int k = 0; k < n; k++)
            {
                int rightNumber = int.Parse(Console.ReadLine());
                sumRight += rightNumber;
            }

            if (sumLeft==sumRight)
            {
                Console.WriteLine($"Yes, sum = {sumRight}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumRight-sumLeft)}");
            }
        }
    }
}
