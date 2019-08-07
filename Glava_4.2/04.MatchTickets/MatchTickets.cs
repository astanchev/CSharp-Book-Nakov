using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MatchTickets
{
    class MatchTickets
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numberOfPeople = int.Parse(Console.ReadLine());

            decimal moneyTransport = 0.00m;
            decimal moneyTickets = 0.00m;
            decimal moneyDifference = 0.00m;

            if (numberOfPeople <= 4) moneyTransport = budget * 0.75m;
            else if (numberOfPeople <= 9) moneyTransport = budget * 0.60m;
            else if (numberOfPeople <= 24) moneyTransport = budget * 0.50m;
            else if (numberOfPeople <= 49) moneyTransport = budget * 0.40m;
            else if (numberOfPeople >= 50) moneyTransport = budget * 0.25m;

            if (category.Equals("VIP")) moneyTickets = numberOfPeople * 499.99m;
            else if (category.Equals("Normal")) moneyTickets = numberOfPeople * 249.99m;

            moneyDifference = budget - moneyTickets - moneyTransport;

            if (moneyDifference>=0)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", moneyDifference);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(moneyDifference));
            }
        }
    }
}
