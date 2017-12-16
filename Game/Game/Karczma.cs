using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Karczma
    {
        static private void powitanie()
        {
            Console.WriteLine("Witaj w karczmie! Co chcesz zrobić?");
        }
        static public void menu()
        {
            Console.Clear();
            Karczma.powitanie();
            ConsoleKeyInfo cki;
            Console.WriteLine("1 - wykonać misję\n2 - odpocząć (przywrócenie hp i many)\n3 - opis\ninne przyciski - wyjść");
            cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.NumPad1)
            {
                Arena.menu();
            }
            else if (cki.Key == ConsoleKey.D2 || cki.Key == ConsoleKey.NumPad2)
            {
                Arena.menu();
            }
            else if (cki.Key == ConsoleKey.D3 || cki.Key == ConsoleKey.NumPad3) 
            {
                Arena.menu();
            }
            else
            {
                Miasto.menu();
            }
        }
    }
}
