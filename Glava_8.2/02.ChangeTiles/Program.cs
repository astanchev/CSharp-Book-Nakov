using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChangeTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double widthFloor = double.Parse(Console.ReadLine());
            double lenghtFloor = double.Parse(Console.ReadLine());
            double sideTile = double.Parse(Console.ReadLine());
            double highTile = double.Parse(Console.ReadLine());
            double priceTile = double.Parse(Console.ReadLine());
            double priceWorker = double.Parse(Console.ReadLine());

            double areaFloor = widthFloor * lenghtFloor;
            double areaTile = (sideTile * highTile) / 2.0;
            double tiles = Math.Ceiling(areaFloor / areaTile) +5;
            double totalPrice = tiles * priceTile + priceWorker;

            if (money>=totalPrice)
            {
                Console.WriteLine($"{money-totalPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {totalPrice- money:f2} lv more.");
            }

        }
    }
}
