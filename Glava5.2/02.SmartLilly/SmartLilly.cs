using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SmartLilly
{
    class SmartLilly
    {
        static void Main(string[] args)
        {
            int ageLilly = int.Parse(Console.ReadLine());
            double priceWashingmashine = double.Parse(Console.ReadLine());
            double priceToy = double.Parse(Console.ReadLine());

            int countToys = 0;
            int countMoney = 0;
            double moneySave = 0;
            double moneyFromToys = 0;
            double allMoney = 0;


            for (int i = 1; i <= ageLilly; i++)
            {
                if (i % 2 != 0)
                {
                    countToys++;
                }
                else if (i % 2 == 0)
                {
                    countMoney++;
                    moneySave = moneySave + (countMoney * 10 - 1);
                }
            }

            moneyFromToys = countToys * priceToy;
            allMoney = moneyFromToys + moneySave;

            if (allMoney>=priceWashingmashine)
            {
                Console.WriteLine($"Yes! {Math.Abs(allMoney-priceWashingmashine):f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(allMoney - priceWashingmashine):f2}");
            }

        }
    }
}
