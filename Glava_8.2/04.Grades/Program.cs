using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int counter5andAbove = 0;
            int counter4to5 = 0;
            int counter3to4 = 0;
            int counterBelow3 = 0;
            double grade = 0.0;
            double totalGrades = 0.0;

            for (int i = 1; i <= students; i++)
            {
                grade = double.Parse(Console.ReadLine());

                if (grade >= 5.0) counter5andAbove++;
                if (grade >= 4.0 && grade < 5.0) counter4to5++;
                if (grade >= 3.0 && grade < 4.0) counter3to4++;
                if (grade < 3.0) counterBelow3++;

                totalGrades += grade;
            }
            Console.WriteLine($"Top students: {counter5andAbove*100.0/students:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {counter4to5*100.0/students:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {counter3to4*100.0/students:f2}%");
            Console.WriteLine($"Fail: {counterBelow3*100.0/students:f2}%");
            Console.WriteLine($"Average: {totalGrades/students:f2}");

        }
    }
}
