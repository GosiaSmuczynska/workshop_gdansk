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
           // int wczytaj = Console.ReadKey(x);
            int x = 5;
            int y = 2;
            int z = x + y;
            Console.ReadKey();

            Console.WriteLine("Wynik sumy dwóch liczb to {0}",z);

            Console.WriteLine("Podaj liczbę pierwszą:");
            string number1 = Console.ReadLine();
            int parsedNumber = int.Parse(number1);

            Console.WriteLine("Podaj liczbę drugą:");
            string number2 = Console.ReadLine();
            int parsedNumber2 = int.Parse(number2);
            Console.WriteLine($"podałeś wartości {parsedNumber} oraz {parsedNumber2}");

            Console.WriteLine(");

            int suma = parsedNumber + parsedNumber2;
            int mnoz = parsedNumber * parsedNumber2;
            int dziel = parsedNumber / parsedNumber2;
            int rozn = parsedNumber - parsedNumber2;

            Console.WriteLine($"Wynik działania: {dzialanie} to {wynik}.");

            Console.ReadKey();
        }
    }
}
