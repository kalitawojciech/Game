using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;

namespace Game
{
    class Miasto
    {
        Karczma karczma;
        Arena arena;
        string nazwa;
        static public void opis()
        {
            Console.Clear();
            Console.WriteLine("Witaj w mieście!");
        }
        static public void menu(Arena arena, Karczma karczma)
        {
            Console.Clear();
            ConsoleKeyInfo cki;
            Console.WriteLine("Dokąd chcesz się udać?\n1 - arena\n2 - karczma\nESC - powrót do menu");
            cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.NumPad1)
            {
                arena.menu();
            }
            else if (cki.Key == ConsoleKey.D2 || cki.Key == ConsoleKey.NumPad2)
            {
                karczma.menu();
            }
            else if (cki.Key == ConsoleKey.Escape)
            {
                // dodać użycie metody statycznej menu() gry
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Nie ma takiej opcji!\nWciśnij dowolny przycisk.");
                Console.ReadKey();
                Miasto.menu(arena, karczma);
            }
        }
    }
}
