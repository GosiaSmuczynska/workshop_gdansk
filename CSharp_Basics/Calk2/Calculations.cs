using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calk2
{
    public static class Calculations
    {
        
        public static double Oblicz(int parsedNumber, int parsedNumber2, string dzialanie)
        {
            double result = 0;
            switch (dzialanie)
            {
                case "+":
                    result = Add(parsedNumber, parsedNumber2);
                    break;

                case "-":
                    result = Substract(parsedNumber, parsedNumber2);
                    break;

                case "*":
                case "x":
                    result = Multiply(parsedNumber, parsedNumber2);
                    break;

                case "/":
                    if (parsedNumber2 == 0)
                    {
                        Console.WriteLine("Nie dziel przez zero");
                        break;
                    }
                    result = Divide(parsedNumber, parsedNumber2);
                    break;

                default:
                    Console.WriteLine("Nie znaleziono symbolu");
                    break;
            }
            return result;
        }

        private static int Add(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
        }

        private static double Divide(int firstNumber, int secondNumber)
        {
            double div = (double)firstNumber / (double)secondNumber;
            return div;
        }

        private static int Multiply(int firstNumber, int secondNumber)
        {
            int mult = firstNumber * secondNumber;
            return mult;
        }

        private static int Substract(int firstNumber, int secondNumber)
        {
            int sub = firstNumber + secondNumber;
            return sub;
        }



    }
}
