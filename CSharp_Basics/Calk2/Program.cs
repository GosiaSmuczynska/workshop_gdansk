using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isRunning = true;
            while (isRunning)
            {

                int parsedNumber = GetValueFromUser("Podaj liczbę pierwszą:");
                int parsedNumber2 = GetValueFromUser("Podaj drugą liczbę:");

                Console.WriteLine("Podaj działanie");
                string dzialanie = Console.ReadLine();
                if (dzialanie == "q")
                {
                    Console.WriteLine("zamykam");
                    Console.ReadKey();
                    return;
                }
  
                double result = 0;
                result = Oblicz(parsedNumber, parsedNumber2, dzialanie);

                Console.WriteLine($"{result}");
            }
            Console.ReadLine();

        }

        public static int GetValueFromUser(string message)
        {
            bool parsed = false;
            int parsedNumber = 0;
            while (!parsed)
                // lub while parsed == true
            {
                Console.WriteLine(message);
                string valueFromUser = Console.ReadLine();
                parsed = int.TryParse(valueFromUser, out parsedNumber);
                if (!parsed)
                {
                    message = $"wartosc {valueFromUser} nieznana, podaj liczbę";
                }
            }
            return parsedNumber;
        }


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


        public static int Add(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
        }

        public static double Divide(int firstNumber, int secondNumber)
        {
            double div = (double)firstNumber / (double)secondNumber;
            return div;
        }

        public static int Multiply(int firstNumber, int secondNumber)
        {
            int mult = firstNumber * secondNumber;
            return mult;
        }

        public static int Substract(int firstNumber, int secondNumber)
        {
            int sub = firstNumber + secondNumber;
            return sub;
        }

    }
}
