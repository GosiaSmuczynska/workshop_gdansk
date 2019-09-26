using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calk2
{
    public static class Calculations
    {
        
       // public static double Oblicz(int parsedNumber, int parsedNumber2, string dzialanie)
        public static double Oblicz(MathData mathData)
        {
            double result = 0;
            switch (mathData.Operation)
            {
                case "+":
                    result = Add(mathData.FirstNumber, mathData.SecondNumber);
                    break;

                case "-":
                    result = Substract(mathData.FirstNumber, mathData.SecondNumber);
                    break;

                case "*":
                case "x":
                    result = Multiply(mathData.FirstNumber, mathData.SecondNumber);
                    break;

                case "/":
                    if (mathData.SecondNumber == 0)
                    {
                        Console.WriteLine("Nie dziel przez zero");
                        break;
                    }
                    result = Divide(mathData.FirstNumber, mathData.SecondNumber);
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
