using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int doctors = 7;
            int checkedPatients = 0;
            int uncheckedPatients = 0;
            int uncheckedPatientsForTheDay = 0;

            for (int i = 1; i <= period; i++)
            {
                int numberPatientsForTheDay = int.Parse(Console.ReadLine());

                if (i % 3 == 0 && uncheckedPatients > checkedPatients)
                {
                    doctors++;
                }

                if (numberPatientsForTheDay>doctors)
                {
                    checkedPatients = checkedPatients + doctors;
                }
                else
                {
                    checkedPatients = checkedPatients + numberPatientsForTheDay;
                }
                
                uncheckedPatientsForTheDay = numberPatientsForTheDay - doctors;
                if ((numberPatientsForTheDay - doctors) < 0)
                {
                    uncheckedPatientsForTheDay = 0;
                }
                uncheckedPatients = uncheckedPatients + uncheckedPatientsForTheDay;
            }
            Console.WriteLine($"Treated patients: {checkedPatients}.");
            Console.WriteLine($"Untreated patients: {uncheckedPatients}.");
        }
    }
}
