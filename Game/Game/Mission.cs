using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Mission
    {
        protected Hero gracz;
        internal Mission(Hero gracz) { this.gracz = gracz; }
        internal void do_mission()
        {
            Console.Clear();
            if (gracz.wykonane_misje < Program.opis_misji.Count)
            {
                Console.WriteLine(Program.opis_misji[gracz.wykonane_misje] + "\n\n1 - podejmij się misji\npozostałe przyciski - powrót");
                ConsoleKeyInfo cki;
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.NumPad1)
                {
                    int i = 1;
                    while (gracz.aktualne_hp > 0 && Program.lista[gracz.wykonane_misje].aktualne_hp > 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Runda {0}, masz {1} hp, przeciwnik ma {2} hp.\nWciśnij dowolny przycisk by kontynuować.", i, gracz.aktualne_hp, Program.lista[gracz.wykonane_misje].aktualne_hp);
                        i++;
                        Console.ReadKey();
                        Program.lista[gracz.wykonane_misje].aktualne_hp -= gracz.menu();
                        if (Program.lista[gracz.wykonane_misje].aktualne_hp > 0)
                        {
                            gracz.aktualne_hp -= Program.lista[gracz.wykonane_misje].si_fight();
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (gracz.aktualne_hp > 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Wygrywasz! Udało Ci się wykonać zadanie.\nWciśnij dowolny przycisk by kontynuować.");
                        Console.ReadKey();
                        gracz.add_experience((gracz.level + 1) * 100);
                        gracz.level_up();
                        gracz.wykonane_misje++;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Niestety tym razem się nie udało. Nie udało Ci się wykonać misji.\nWciśnij dowolny przycisk by kontynuować.");
                        Console.ReadKey();
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Aktualnie nie ma nowych misji, wróć później.\n\nWciśnij dowolny przycisk by kontynuować.");
                Console.ReadKey();
            }
            Console.ReadKey();
            Karczma karczma = new Karczma();
            karczma.gracz = gracz;
            karczma.menu();
        }
        
    }
}
