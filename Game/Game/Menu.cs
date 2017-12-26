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
            Console.WriteLine("1 - nowa gra\n2 - wczytaj grę - brak\n3 - zapisz grę - brak\nEsc - wyjście - brak");
            ConsoleKeyInfo cki;
            cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.NumPad1)
            {
                Console.Clear();
                Console.WriteLine("Jaką postać chcesz grać?\n1 - wojownik\n2 - mag\n3 - łucznik");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.NumPad1)
                {
                    Wojownik gracz = new Wojownik();
                    Karczma karczma = new Karczma();
                    Arena arena = new Arena();
                    Wojownik enemy = new Wojownik();
                    Miasto miasto = new Miasto();
                    miasto.gracz = gracz;
                    miasto.menu();
                    Console.ReadKey();
                }
                else if (cki.Key == ConsoleKey.D2 || cki.Key == ConsoleKey.NumPad2)
                {
                    Mag gracz = new Mag();
                    Karczma karczma = new Karczma();
                    Arena arena = new Arena();
                    Wojownik enemy = new Wojownik();
                    Miasto miasto = new Miasto();
                    miasto.gracz = gracz;
                    miasto.menu();
                    Console.ReadKey();
                }
                else
                {
                    Lucznik gracz = new Lucznik();
                    Karczma karczma = new Karczma();
                    Arena arena = new Arena();
                    Wojownik enemy = new Wojownik();
                    Miasto miasto = new Miasto();
                    miasto.gracz = gracz;
                    miasto.menu();
                    Console.ReadKey();
                }
            }
            else if (cki.Key == ConsoleKey.D2 || cki.Key == ConsoleKey.NumPad2)
            {
                throw new NotImplementedException();
            }
            else if (cki.Key == ConsoleKey.D3 || cki.Key == ConsoleKey.NumPad3)
            {
                throw new NotImplementedException();
            }
            else if (cki.Key == ConsoleKey.Escape)
            {
                throw new NotImplementedException();
            }
        }

    }
}
