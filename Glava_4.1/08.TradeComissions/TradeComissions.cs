using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TradeComissions
{
    class TradeComissions
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());
            double commission = -1.0;

            if (town == "sofia")
            {
                if (sales >= 0 && sales <= 500) commission = 0.05;
                else if (sales > 500 && sales <= 1000) commission = 0.07;
                else if (sales > 1000 && sales <= 10000) commission = 0.08;
                else if (sales > 10000) commission = 0.12;
            }
            else if (town == "varna")
            {
                if (sales >= 0 && sales <= 500) commission = 0.045;
                else if (sales > 500 && sales <= 1000) commission = 0.075;
                else if (sales > 1000 && sales <= 10000) commission = 0.10;
                else if (sales > 10000) commission = 0.13;
            }
            else if (town == "plovdiv")
            {
                if (sales >= 0 && sales <= 500) commission = 0.055;
                else if (sales > 500 && sales <= 1000) commission = 0.08;
                else if (sales > 1000 && sales <= 10000) commission = 0.12;
                else if (sales > 10000) commission = 0.145;
            }
            if (commission > 0) Console.WriteLine("{0:f2}",commission*sales);
            else Console.WriteLine("error");

        }
    }
}
