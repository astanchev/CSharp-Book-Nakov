﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            string word = "";
            int matchings = 0;
            int weight = 0;

            for (char i = 'a'; i <= 'e'; i++)
            {
                for (char j = 'a'; j <= 'e'; j++)
                {
                    for (char k = 'a'; k <= 'e'; k++)
                    {
                        for (char l = 'a'; l <= 'e'; l++)
                        {
                            for (char m = 'a'; m <= 'e'; m++)
                            {
                                word = i.ToString() + j.ToString() + k.ToString() + l.ToString() + m.ToString();
                                word = new string(word.ToCharArray().Distinct().ToArray());
                                for (int d = 1; d <= word.Length; d++)
                                {
                                    switch (word[d - 1])
                                    {
                                        case 'a':
                                            weight += d * 5;
                                            break;
                                        case 'b':
                                            weight += d * -12;
                                            break;
                                        case 'c':
                                            weight += d * 47;
                                            break;
                                        case 'd':
                                            weight += d * 7;
                                            break;
                                        case 'e':
                                            weight += d * -32;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                if (weight >= start && weight <= end)
                                {
                                    matchings++;
                                    Console.Write($"{i}{j}{k}{l}{m} ");
                                    
                                }
                                weight = 0;
                            }
                        }
                    }
                }
            }

            if (matchings == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
    

