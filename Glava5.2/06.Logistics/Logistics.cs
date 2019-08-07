using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Logistics
{
    class Logistics
    {
        static void Main(string[] args)
        {
            int numberOfLoads = int.Parse(Console.ReadLine());

            double priceBus = 0.0;
            double priceTruck = 0.0;
            double priceTrain = 0.0;
            int loadBus = 0;
            int loadTruck = 0;
            int loadTrain = 0;



            for (int i = 0; i < numberOfLoads; i++)
            {
                int load = int.Parse(Console.ReadLine());
                if (load <= 3)
                {
                    loadBus += load;
                    priceBus = priceBus + (load * 200);
                }
                else if (load <= 11)
                {
                    loadTruck += load;
                    priceTruck = priceTruck + (load * 175);
                }
                else if (load > 11)
                {
                    loadTrain += load;
                    priceTrain = priceTrain + (load * 120);
                }
            }

            int loadTotal = loadBus + loadTruck + loadTrain;
            double pricePerTon = (priceBus + priceTruck + priceTrain) / loadTotal;

            Console.WriteLine($"{pricePerTon:f2}");
            Console.WriteLine($"{loadBus * 100.0 / loadTotal:0.00}%");
            Console.WriteLine($"{loadTruck * 100.0 / loadTotal:0.00}%");
            Console.WriteLine($"{loadTrain * 100.0 / loadTotal:0.00}%");

        }
    }
}
