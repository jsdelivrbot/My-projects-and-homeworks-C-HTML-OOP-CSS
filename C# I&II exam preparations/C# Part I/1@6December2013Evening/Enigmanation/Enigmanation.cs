﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigmanation.TestGenerator
{
    class EnigmanationSolution
    {
        static void Main()
        {
            int symbol = Console.Read();
            decimal sum = 0;
            int func = '+';

            while (symbol != '=')
            {
                if (symbol == '(')
                {
                    decimal innerSum = 0;
                    int innerO = '+';
                    symbol = Console.Read();

                    while (symbol != ')')
                    {
                        if (0 <= symbol - '0' && symbol - '0' <= 9)
                        {
                            switch (innerO)
                            {
                                case '+':innerSum += symbol - '0';break;
                                case '-':innerSum -= symbol - '0';break;
                                case '*':innerSum *= symbol - '0';break;
                                case '%':innerSum %= symbol - '0';break;
                            }
                        }
                        else if (symbol == '+' ||symbol == '-' ||symbol == '%' ||symbol == '*')
                        {
                            innerO = symbol;
                        }
                        symbol = Console.Read();
                    }

                    switch (func)
                    {
                        case '+':sum += innerSum;break;
                        case '-':sum -= innerSum;break;
                        case '*':sum *= innerSum;break;
                        case '%':sum %= innerSum;break;
                    }
                }
                else if (0 <= symbol - '0' && symbol - '0' <= 9)
                {
                    switch (func)
                    {
                        case '+':sum += symbol - '0';break;
                        case '-':sum -= symbol - '0';break;
                        case '*':sum *= symbol - '0';break;
                        case '%':sum %= symbol - '0';break;
                    }
                }
                else if (symbol == '+' ||symbol == '-' ||symbol == '*' ||symbol == '%')
                {
                    func = symbol;
                }
                symbol = Console.Read();
            }
            Console.WriteLine("{0:0.000}", sum);
        }
    }
}