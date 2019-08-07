using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.XExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            int symbol = Console.Read();
            decimal rezult = 0.0m;
            int expressionOperator = '+';

            while (symbol != '=')
            {
                if (symbol == '(')
                {
                    decimal innerResult = 0.0m;
                    int innerOperator = '+';
                    symbol = Console.Read();
                    while (symbol != ')')
                    {
                        if (0 <= symbol - '0' && symbol - '0' <= 9)
                        {
                            switch (innerOperator)
                            {
                                case '+': innerResult += symbol - '0'; break;
                                case '-': innerResult -= symbol - '0'; break;
                                case '/': innerResult /= symbol - '0'; break;
                                case '*': innerResult *= symbol - '0'; break;
                                default: break;
                            }
                        }
                        else if (symbol == '+' || symbol == '-' || symbol == '/' || symbol == '*')
                        {
                            innerOperator = symbol;
                        }
                        symbol = Console.Read();
                    }
                    
                    switch (expressionOperator)
                    {
                        case '+': rezult += innerResult; break;
                        case '-': rezult -= innerResult; break;
                        case '/': rezult /= innerResult; break;
                        case '*': rezult *= innerResult; break;
                        default: break;
                    }
                }
                else if (0 <= symbol - '0' && symbol - '0' <= 9)
                {
                    switch (expressionOperator)
                    {
                        case '+': rezult += symbol - '0'; break;
                        case '-': rezult -= symbol - '0'; break;
                        case '/': rezult /= symbol - '0'; break;
                        case '*': rezult *= symbol - '0'; break;
                        default: break;
                    }
                }
                else if (symbol=='+'|| symbol == '-' || symbol == '/' || symbol == '*')
                {
                    expressionOperator = symbol;
                }
                symbol = Console.Read();
            }
            Console.WriteLine($"{rezult:f2}");
        }
    }
}
