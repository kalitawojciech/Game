using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Menu
    {
        public static void menu()
        {
            Console.WriteLine("1 - graj\n2 - zapisz grę\nEsc - wyjście");
            ConsoleKeyInfo cki;
            cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.NumPad1)
            {
                
            }
            else if (cki.Key == ConsoleKey.D2 || cki.Key == ConsoleKey.NumPad2)
            {
                
            }
            else if (cki.Key == ConsoleKey.Escape)
            {

            }
        }

    }
}
