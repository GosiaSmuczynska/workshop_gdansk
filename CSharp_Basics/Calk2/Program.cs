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

                MathData mathData = UserInterface.GetAllValuesFromCustomer();
                //to już nie jest statycznie więc musimy stworzyć element
            //mathData.FirstNumber = UserInterface.GetValueFromUser("Podaj liczbę pierwszą:");
            //  //  int parsedNumber = UserInterface.GetValueFromUser("Podaj liczbę pierwszą:");
            //    if (quit)
            //    {  UserInterface.Quit();                     //wyjdzie z metody, a break wyjdzie z while
            //    }
            //    mathData.SecondNumber = UserInterface.GetValueFromUser("Podaj drugą liczbę:");
            // //   int parsedNumber2 = UserInterface.GetValueFromUser("Podaj drugą liczbę:");
            //    if (quit)
            //    {  UserInterface.Quit();
            //    }

                string dzialanie = UserInterface.GetOperation();
                var result = Calculations.Oblicz(mathData);

                Console.WriteLine($"{result}");
            }
            Console.ReadLine();

        }

        
       
    }
}
