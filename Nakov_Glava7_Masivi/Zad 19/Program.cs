using System;

namespace Zad19_Sieve_of_Erathostenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] array = new bool[n + 1];
            for (int i = 0; i <= n; i++)
            {
                array[i] = true;
            }
            array[0] = false;
            array[1] = false;
            for (int i = 2; i < array.Length; i++)
            {
                if (array[i])
                {
                    for (int j = 2; (j * i) <= n; j++)
                    {
                        array[j * i] = false;
                    }
                }
            }
            for (int j = 2; j <= n; j++)
            {
                if (array[j] == true)
                { Console.Write(j + " "); }
            }
            Console.WriteLine();



        }
    }
}
