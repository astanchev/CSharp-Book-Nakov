using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Trip
{
    class Trip
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = string.Empty;            
            string typeVacantion = string.Empty;
            decimal spentMoney = 0.00m;

            if (budget <= 100.00m)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    spentMoney = 0.30m * budget;
                    typeVacantion = "Camp";
                }
                else
                {
                    spentMoney = 0.70m * budget;
                    typeVacantion = "Hotel";
                }
            }
            else if (budget <= 1000.00m)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    spentMoney = 0.40m * budget;
                    typeVacantion = "Camp";
                }
                else
                {
                    spentMoney = 0.80m * budget;
                    typeVacantion = "Hotel";
                }
            }
            else
            {
                destination = "Europe";
                spentMoney = 0.90m * budget;
                typeVacantion = "Hotel";
            }

            Console.WriteLine("Somewhere in {0}", destination);
            Console.WriteLine("{0} - {1:f2}", typeVacantion, spentMoney);
        }
    }
}
