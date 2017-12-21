using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Arena
    {
        public Arena arena;
        public Karczma karczma;
        public void menu()
        {
            ConsoleKeyInfo cki;
            Console.Clear();
            Console.WriteLine("Witaj na arenie! Co chcesz zrobić?\n1 - walka\n2 - opis\n3 - wyjść");
            cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.NumPad1 || cki.Key == ConsoleKey.D1)
            {
            }
            else if (cki.Key == ConsoleKey.NumPad2 || cki.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.WriteLine("To tutaj, na arenie dzielni wojownicy walczą by udowodnić swą potęgę!\nWciśnij dowolny przycisk by wrócić.");
                Console.ReadKey();
                Arena a = new Arena();
                a.menu();
            }
            else if (cki.Key == ConsoleKey.NumPad3 || cki.Key == ConsoleKey.D3)
            {
                Miasto.menu(arena, karczma);
            }
        }
    }
}
