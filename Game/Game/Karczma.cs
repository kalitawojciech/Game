using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Karczma
    {
        public Karczma() {}
        public Hero gracz;
        public void menu()
        {
            Console.Clear();
            Console.WriteLine("Witaj w karczmie! Co chcesz zrobić?");
            ConsoleKeyInfo cki;
            Console.WriteLine("1 - wykonać misję\n2 - odpocząć (przywrócenie hp i many)\n3 - opis\ninne przyciski - powrót");
            cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.NumPad1)
            {
                throw new NotImplementedException();
            }
            else if (cki.Key == ConsoleKey.D2 || cki.Key == ConsoleKey.NumPad2)
            {
                Console.Clear();
                gracz.odpocznij();
                Console.WriteLine("Odpoczynek zakończony!\nAby kontynuować wciśnij dowolny przycisk.");
                Console.ReadKey();
                Karczma karczma = new Karczma();
                karczma.gracz = gracz;
                karczma.menu();
            }
            else if (cki.Key == ConsoleKey.D3 || cki.Key == ConsoleKey.NumPad3) 
            {
                Console.Clear();
                Console.WriteLine("Karczma to miejsce w którym możesz dostać zadanie od różnych dziwnych ludzi.\nW wolnej chwili możesz zregenerować swoje hp i manę podczas odpoczynku.\n Wciśnij dowolny przycisk by kontynuować.");
                Console.ReadKey();
                Karczma karczma = new Karczma();
                karczma.gracz = gracz;
                karczma.menu();
            }
            else
            {
                Miasto miasto = new Miasto();
                miasto.gracz = gracz;
                miasto.menu();
            }
        }
    }
}