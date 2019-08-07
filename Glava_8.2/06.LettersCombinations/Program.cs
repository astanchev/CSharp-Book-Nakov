using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            char scipLetter = char.Parse(Console.ReadLine());
            int counter = 0;

            for (char i = startLetter; i <= endLetter; i++)
            {
                if (i == scipLetter) continue;                
                for (char j = startLetter; j <= endLetter; j++)
                {
                    if (j == scipLetter) continue;
                    for (char k = startLetter; k <= endLetter; k++)
                    {
                        if (k == scipLetter) continue;
                        Console.Write($"{i}{j}{k} ");
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
