using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HotelRoom
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberNights = int.Parse(Console.ReadLine());

            decimal studioPrice = 50.00m;
            decimal apartamentPrice = 65.00m;
            decimal studioRent = 0.00m;
            decimal apartamentRent = 0.00m;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50.00m;
                    apartamentPrice = 65.00m;
                    studioRent = studioPrice * numberNights;
                    apartamentRent = apartamentPrice * numberNights;
                    if (numberNights > 14)
                    {
                        studioRent = studioRent * 0.70m;
                        apartamentRent = apartamentRent * 0.90m;                        
                    }
                    else if (numberNights > 7)
                    {
                        studioRent = studioRent * 0.95m;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 75.20m;
                    apartamentPrice = 68.70m;
                    studioRent = studioPrice * numberNights;
                    apartamentRent = apartamentPrice * numberNights;
                    if (numberNights > 14)
                    {
                        studioRent = studioRent * 0.80m;
                        apartamentRent = apartamentRent * 0.90m;
                    }
                    break;
                case "July":
                case "August":
                    studioPrice = 76.00m;
                    apartamentPrice = 77.00m;
                    studioRent = studioPrice * numberNights;
                    apartamentRent = apartamentPrice * numberNights;
                    if (numberNights > 14)
                    {
                        apartamentRent = apartamentRent * 0.90m;
                    }
                    break;
            }
            Console.WriteLine("Apartment: {0:f2} lv.", Math.Round(apartamentRent,2));
            Console.WriteLine("Studio: {0:f2} lv.", Math.Round(studioRent,2));
        }
    }
}
