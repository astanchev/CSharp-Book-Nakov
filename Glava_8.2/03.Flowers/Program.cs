using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberChrizanthems = int.Parse(Console.ReadLine());
            int numberRoses = int.Parse(Console.ReadLine());
            int numberTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();
            double priceChr = 0.0;
            double priceR = 0.0;
            double priceT = 0.0;
            double bouquet = 0.0;
            

            if (season == "Spring" || season == "Summer")
            {
                priceChr = 2.0;
                priceR = 4.1;
                priceT = 2.5;
                if (holiday == "Y")
                {
                    priceChr *= 1.15;
                    priceR *= 1.15;
                    priceT *= 1.15;
                }
                bouquet = priceChr * numberChrizanthems + priceR * numberRoses + priceT * numberTulips;
                if (numberTulips>7&& season == "Spring")
                {
                    bouquet *= 0.95;
                }
                if (numberChrizanthems+numberRoses+numberTulips>20)
                {
                    bouquet *= 0.8;
                }
                
            }
            else if (season == "Autumn" || season == "Winter")
            {
                priceChr = 3.75;
                priceR = 4.5;
                priceT = 4.15;
                if (holiday == "Y")
                {
                    priceChr *= 1.15;
                    priceR *= 1.15;
                    priceT *= 1.15;
                }
                bouquet = priceChr * numberChrizanthems + priceR * numberRoses + priceT * numberTulips;
                if (numberRoses >= 10 && season == "Winter")
                {
                    bouquet *= 0.9;
                }
                if (numberChrizanthems + numberRoses + numberTulips > 20)
                {
                    bouquet *= 0.8;
                }
            }
            bouquet += 2;
            Console.WriteLine($"{bouquet:f2}");
        }
    }
}
