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
            //int x = 5;
            //int y = 2;
            //int z = x + y;
            //Console.ReadKey();

            //Console.WriteLine("Wynik sumy dwóch liczb to {0}",z);

            Console.WriteLine("Podaj liczbę pierwszą:");
            string number1 = Console.ReadLine();
            int parsedNumber = int.Parse(number1);

            Console.WriteLine("Podaj liczbę drugą:");
            string number2 = Console.ReadLine();
            int parsedNumber2 = int.Parse(number2);
            Console.WriteLine($"podałeś wartości {parsedNumber} oraz {parsedNumber2}");

            Console.WriteLine("Jakie działanie chcesz wykonać?");
            Console.WriteLine("s-suma, m-mnożenie, d-dzielenie, r-roznica");

            int result = Add(parsedNumber, parsedNumber2);
            double divide = Divide(parsedNumber, parsedNumber2);
            int multiply = Multiply(parsedNumber, parsedNumber2);
            int substract = Substract(parsedNumber, parsedNumber2);
           
           // Console.WriteLine($"Wynik działania: {dzialanie} to {wynik}.");

            Console.ReadKey();
        }

        public static int Add(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
        }

        public static double Divide(int firstNumber, int secondNumber)
        {
            double div = firstNumber / secondNumber;
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
