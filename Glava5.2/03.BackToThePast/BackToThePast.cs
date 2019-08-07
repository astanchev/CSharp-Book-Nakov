using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BackToThePast
{
    class BackToThePast
    {
        static void Main(string[] args)
        {
            double moneyInherited = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());


            for (int i = 1800, j = 18; i <= yearToLive; i++, j++)
            {
                if (i % 2 == 0)
                {
                    moneyInherited = moneyInherited - 12000;
                }
                else
                {
                    moneyInherited=moneyInherited-(12000 + j*50);
                }
            }

            if (moneyInherited>=0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {moneyInherited:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(moneyInherited):f2} dollars to survive.");
            }

        }
    }
}
