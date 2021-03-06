﻿using System;

namespace Zad17_Merge_Sort
{
    class Program
    {
        static int[] Splits(int[] arr)
        {
            if (arr.Length == 1) // Ако дължината на масива стане равна на 1 елемент,
            {                    // тогава се връща този елемент и отиваме към другия метод
                return arr;
            }
            // Инициализират се два масива с равен брой елемента спрямо подаденият масив(arr).
            int middle = arr.Length / 2;
            int[] leftArr = new int[middle];
            int[] rightArr = new int[arr.Length - middle];//Ако елементите са нечетен брой така тук попада по-голямата половина
            // Слагаме в първия масив(left), половината от елементите на подадения масив (arr).
            for (int i = 0; i < middle; i++)
            {
                leftArr[i] = arr[i];
            }
            // Слагаме във втория масив(right), другата половината от елементи на подадения масив (arr).
            for (int i = middle, j = 0; i < arr.Length; i++, j++)
            {
                rightArr[j] = arr[i];
            }

            leftArr = Splits(leftArr);   // Вика се рекурсия на лявата половина, докато нейната дължина не стане равна на 1.
            rightArr = Splits(rightArr); // След като свършим изцяло с лявата половина на първоначално подадения масив,
                                         // прави се същото и с дясната половина, докато не се изчерпят всички нейни стойности

            return Merge(leftArr, rightArr); // Когато в двата масива остане само по 1 елемент, викаме метода
                                             // Merge, който ще ги слее, разпределени по големина

        }

        static int[] Merge(int[] left, int[] right)
        {
            // Първоначално се сравнява нулевия елемент на левия масив с нулевия елемент на десния.
            int leftIncrease = 0;
            int rightIncrease = 0;
            int[] arr = new int[left.Length + right.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                // Ако левият елемент е по-малък, той се записва в масива (arr) и се увеличава левия брояч (leftIncrease) с 1
                // Ако всички елементи в десния масив свършат, то се прехвърлят автоматично останалите елементи в левия масив.
                if (rightIncrease == right.Length || ((leftIncrease < left.Length) && (left[leftIncrease] <= right[rightIncrease])))
                {
                    arr[i] = left[leftIncrease];
                    leftIncrease++;
                }
                else if (leftIncrease == left.Length || ((rightIncrease < right.Length) && (left[leftIncrease] >= right[rightIncrease])))
                {
                    arr[i] = right[rightIncrease];
                    rightIncrease++;
                }
            }
            return arr;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int arrayLength = int.Parse(Console.ReadLine());

            int[] array = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Index {i} -> ");
                array[i] = int.Parse(Console.ReadLine());
            }

            //Извикваме метода Splits
            array = Splits(array);

            Console.WriteLine("After Sort:");
            //Разпечатваме
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine($"Index {i} -> {array[i]}");
            }




        }
    }
}
