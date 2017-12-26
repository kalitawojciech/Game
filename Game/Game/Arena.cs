using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Arena
    {
        public Hero gracz;
        public void menu()
        {
            ConsoleKeyInfo cki;
            Console.Clear();
            Console.WriteLine("Witaj na arenie! Co chcesz zrobić?\n1 - walka\n2 - opis\n3 - wyjść");
            cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.NumPad1 || cki.Key == ConsoleKey.D1)
            {
                Console.Clear();
                Console.WriteLine("Z kim chcesz walczyć\n1 - inny bohater");
                cki = Console.ReadKey();
                if(cki.Key == ConsoleKey.NumPad1 || cki.Key == ConsoleKey.D1)
                {
                    Walka_vs_Hero walka = new Walka_vs_Hero(gracz);
                    walka.gracz = gracz;
                    walka.walka();
                    Arena arena = new Arena();
                    arena.gracz = gracz;
                    arena.menu();
                }
            }
            else if (cki.Key == ConsoleKey.NumPad2 || cki.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.WriteLine("To tutaj, na arenie dzielni wojownicy walczą by udowodnić swą potęgę!\nWciśnij dowolny przycisk by wrócić.");
                Console.ReadKey();
                Arena arena = new Arena();
                arena.gracz = gracz;
                arena.menu();
            }
            else if (cki.Key == ConsoleKey.NumPad3 || cki.Key == ConsoleKey.D3)
            {
                Miasto miasto = new Miasto();
                miasto.gracz = gracz;
                miasto.menu();
            }
        }
    }
}
