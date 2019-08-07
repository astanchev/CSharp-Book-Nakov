using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PassionDays
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int purchases = 0;
            decimal price = 0.0m;
            while (command != "mall.Enter")
            {
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while (command != "mall.Exit")
            {
                foreach (char action in command)
                {
                    if (action >= 'A' && action <= 'Z')
                    {
                        price = 0.5m * action;
                        if (price > money || money == 0)
                        {
                            continue;
                        }
                        money -= price;
                        purchases++;
                    }
                    else if (action >= 'a' && action <= 'z')
                    {
                        price = 0.3m * action;
                        if (price > money || money == 0)
                        {
                            continue;
                        }
                        money -= price;
                        purchases++;
                    }
                    else if (action == '%')
                    {
                        price = money * 0.5m;
                        if (price > money || money == 0)
                        {
                            continue;
                        }
                        money -= price;
                        purchases++;
                    }
                    else if (action == '*')
                    {
                        money += 10.0m;

                    }
                    else
                    {
                        price = action;
                        if (price > money || money == 0)
                        {
                            continue;
                        }
                        money -= price;
                        purchases++;
                    }
                }
                command = Console.ReadLine();
            }
            if (purchases == 0)
            {
                Console.WriteLine($"No purchases. Money left: {money:f2} lv.");
            }
            else
            {
                Console.WriteLine($"{purchases} purchases. Money left: {money:f2} lv.");
            }
        }
    }
}
