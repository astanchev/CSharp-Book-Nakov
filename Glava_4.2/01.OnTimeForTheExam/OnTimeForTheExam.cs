using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OnTimeForTheExam
{
    class OnTimeForTheExam
    {
        static void Main(string[] args)
        {
            int examHours = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHours = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int examMinutesAll = examHours * 60 + examMinutes;
            int arrivalMinutesAll = arrivalHours * 60 + arrivalMinutes;
            int difference = examMinutesAll - arrivalMinutesAll;

            string late = "Late";
            string onTime = "On time";
            string early = "Early";

            string studentArrival = late;

            if (difference >= 0 && difference <= 30) studentArrival = onTime;
            else if (difference > 30) studentArrival = early;

            string result = null;
            if (difference !=0)
            {
                int hoursDifference = Math.Abs(difference / 60);
                int minutesDifference = Math.Abs(difference % 60);
                if(hoursDifference > 0)
                {
                    result = string.Format("{0}:{1:00} hours", hoursDifference, minutesDifference);
                }
                else
                {
                    result = minutesDifference + " minutes";
                }
                if (difference>0)
                {
                    result = result + " before the start";
                }
                else
                {
                    result += " after the start";
                }
            }

            Console.WriteLine(studentArrival);
            if (result != null)
            {
                Console.WriteLine(result);
            }
        }
    }
}
