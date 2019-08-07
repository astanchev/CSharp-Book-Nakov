using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.GenerateRectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int left = -n; left < n; left++)
            {
                for (int top = -n; top < n; top++)
                {
                    for (int right = left + 1; right <= n; right++)
                    {
                        for (int bottom = top + 1; bottom <= n; bottom++)
                        {
                            int area = Math.Abs(right - left) * Math.Abs(bottom - top);
                            if (area >= m)
                            {
                                Console.WriteLine($"({left}, {top}) ({right}, {bottom}) -> {area}");
                                counter++;
                            }
                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
