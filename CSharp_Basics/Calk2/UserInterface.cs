using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calk2
{
    class UserInterface
    {

       // public static class 
        static bool quit = false;

        public static void Quit()
        {
            Console.WriteLine("Zamykam aplikacje");
            Console.ReadKey();
            Environment.Exit(0);
        }

        public static string GetOperation()
        {
            Console.WriteLine("Podaj działanie");
            string dzialanie = Console.ReadLine();
            if (dzialanie == "q")
            {
                Quit();
            }
            return dzialanie;
            
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
                if (valueFromUser == "q")
                {
                    Quit();
                }
                parsed = int.TryParse(valueFromUser, out parsedNumber);
                if (!parsed)
                {
                    message = $"wartosc {valueFromUser} nieznana, podaj liczbę";
                }
            }
            return parsedNumber;
        }

    }
}
