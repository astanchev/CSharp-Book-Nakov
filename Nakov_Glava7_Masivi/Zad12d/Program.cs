using System;

namespace Zad12d
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter arr size: ");
            int length = Int32.Parse(Console.ReadLine());

            int[,] matrix = new int[length, length];
            int numConcentricSquares = (int)Math.Ceiling((length) / 2.0);//Брой на концентричните квадрати
            int sideLen = length;//Дължина на текущата страна на квадрата
            int currentNumber = 0;

            for (int i = 0; i < numConcentricSquares; i++)//Попълване на концентричните квадрати един по един
            {

                for (int j = 0; j < sideLen; j++)//Пълнене на лявата страна
                {
                    matrix[i + j, i] = ++currentNumber;//колоната е постоянна
                }
                for (int j = 1; j < sideLen - 1; j++)//Пълнене на долната страна - от втората до последната клетка
                {
                    matrix[(length - 1) - i, i + j] = ++currentNumber; //реда  е постоянен
                }
                for (int j = sideLen - 1; j > 0; j--)//Пълнене на дясната страна - от долу нагоре- от втората до предпоследната
                {
                    matrix[i + j, length - 1 - i] = ++currentNumber;//колоната е постоянна
                }
                for (int j = sideLen - 1; j > 0; j--)//Пълнене на горната страна - дясно наляво - от последната клетка на реда до втората
                {
                    matrix[i, i + j] = ++currentNumber;
                }
                sideLen -= 2;//Намаляваме страната с две клетки (в ъглите клетките отпадат) за следващия квадрат
            }

            //Отпечатване
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, 4}", matrix[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
