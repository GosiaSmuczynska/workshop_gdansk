using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calk2
{
    class Program
    {
        static bool quit = false; //teraz ta wartość jest widoczna wszędzie, nawet w metodach
        static void Main(string[] args)
        {
            // bool isRunning = true;
            while (!quit)
            {
            int parsedNumber = UserInterface.GetValueFromUser("Podaj liczbę pierwszą:");
                if (quit)
                {  UserInterface.Quit();                     //wyjdzie z metody, a break wyjdzie z while
                }
            int parsedNumber2 = UserInterface.GetValueFromUser("Podaj drugą liczbę:");
                if (quit)
                {  UserInterface.Quit();
                }

                string dzialanie = UserInterface.GetOperation();
                double result = 0;
                result = Calculations.Oblicz(parsedNumber, parsedNumber2, dzialanie);

                Console.WriteLine($"{result}");
            }
            Console.ReadLine();

        }

        
       
    }
}
