using System;

namespace Zad24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            if (1 <= k && k <= n)
            {
                int variations = 1;
                for (int i = n; i > n - k; i--)
                {
                    variations *= i;
                }
                Console.WriteLine("Variations = " + variations);

                for (int i = 0; i < variations; i++)
                {
                    // isNotAvailable is false i.e. isAvailable
                    bool[] isNotAvailable = new bool[n];

                    int numberOfAvailElems = n;
                    int variationsOfAvailElems = variations;

                    for (int j = 0; j < k; j++)
                    {
                        numberOfAvailElems--;

                        // size of lots (number of consequtive rows with
                        // the same elements in columns from 0 to j),
                        // i.e. the number of variations of the available
                        // elements
                        if (numberOfAvailElems + 1 > 0)
                        {
                            variationsOfAvailElems /= (numberOfAvailElems + 1);
                        }
                        else
                        {
                            variationsOfAvailElems = 1;
                        }

                        // lot identifier, i.e. the number of full lots
                        // which lie before the current row
                        int lotId = i / variationsOfAvailElems;

                        int indexInListOfAvailElems =
                           lotId % (numberOfAvailElems + 1);

                        int x = 0;
                        int counterOfAvailElems =
                           indexInListOfAvailElems + 1;
                        while (x < n && counterOfAvailElems > 0)
                        {
                            if (!isNotAvailable[x])
                            {
                                counterOfAvailElems--;
                            }
                            x++;
                        }
                        isNotAvailable[x - 1] = true;

                        Console.Write("{0,3}", x);
                    }
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine(
                   "Invalid data! Let 1 <= k <= n.");
            }
        }
    }
}
