using System;

namespace Zad_6_Longest_left
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array lenght: ");
            int lenght = int.Parse(Console.ReadLine());
            int[] seq = new int[lenght];
            int[] len = new int[seq.Length];
            int[] prev = new int[seq.Length];
            int maxLen = 0;
            int lastIndex = 0;


            for (int i = 0; i < seq.Length; i++)
            {
                Console.Write($"Enter {i} element: ");
                seq[i] = int.Parse(Console.ReadLine());
            }

            for (int x = 0; x < seq.Length; x++)
            {
                len[x] = 1;
                prev[x] = -1;
                for (int i = 0; i < x; i++)
                {
                    if ((seq[i] < seq[x]) && (len[i] + 1 > len[x]))
                    {
                        len[x] = len[i] + 1;
                        prev[x] = i;
                    }
                }
                if (len[x] > maxLen)
                {
                    maxLen = len[x];
                    lastIndex = x;
                }
            }

            
            Console.WriteLine();
            Console.WriteLine("Index: ");
            for (int i = 0; i < seq.Length; i++)
            {
                Console.Write($"{i,3} ");
            }
            Console.WriteLine();
            Console.WriteLine("Seq:  ");
            for (int i = 0; i < seq.Length; i++)
            {
                Console.Write($"{seq[i],3} ");
            }
            Console.WriteLine();
            Console.WriteLine("Len: ");
            for (int i = 0; i < len.Length; i++)
            {
                Console.Write($"{len[i],3} ");
            }
            Console.WriteLine();
            Console.WriteLine("Prev: ");
            for (int i = 0; i < prev.Length; i++)
            {
                Console.Write($"{prev[i],3} ");
            }
            Console.WriteLine();



            int[] reversed = new int[maxLen];
            reversed[0] = seq[lastIndex];
            
            for (int i = 1; i < maxLen; i++)
            {
                reversed[i] = seq[prev[lastIndex]];
                lastIndex = prev[lastIndex];

            }
            Console.WriteLine();
            Console.WriteLine($"The longest sequence is: {maxLen}");
            Console.WriteLine();
            for (int i = maxLen - 1; i >= 0; i--)
            {
                Console.Write($"{reversed[i]} ");
            }
            
        }
    }
}
