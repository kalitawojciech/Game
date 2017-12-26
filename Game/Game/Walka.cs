using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    abstract class Walka
    {
        internal Hero gracz;
        internal abstract void walka();
    }

    class Walka_vs_Hero : Walka
    {
        internal Walka_vs_Hero(Hero gracz) { this.gracz = gracz; }
        internal override void walka()
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 4);
            if(a == 1)
            {
                Console.Clear();
                Wojownik_SI przeciwnik = new Wojownik_SI();
                Console.WriteLine("Twoim przeciwnikem jest wojownik na poziomie {0}!\nWciśnij dowolny przycisk by kontynuuować", przeciwnik.level);
                przeciwnik.lvl_up(gracz.level);
                Console.ReadKey();
                int i = 1;
                while (gracz.aktualne_hp > 0 && przeciwnik.aktualne_hp > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Runda {0}, masz {1} hp, przeciwnik ma {2} hp.\nWciśnij dowolny przycisk by kontynuować.", i, gracz.aktualne_hp, przeciwnik.aktualne_hp);
                    i++;
                    Console.ReadKey();
                    przeciwnik.aktualne_hp -= gracz.menu();
                    if (przeciwnik.aktualne_hp > 0)
                    {
                        gracz.aktualne_hp -= przeciwnik.si_fight();
                    }
                    else
                    {
                        continue;
                    }
                }
                if(gracz.aktualne_hp > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Wygrywasz!\nWciśnij dowolny przycisk by kontynuować.");
                    Console.ReadKey();
                    gracz.add_experience((przeciwnik.level + 1) * 50);
                    gracz.level_up();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Niestety tym razem się nie udało.\nWciśnij dowolny przycisk by kontynuować.");
                    Console.ReadKey();
                }
            }
            if (a == 2)
            {
                Console.Clear();
                Mag_SI przeciwnik = new Mag_SI();
                Console.WriteLine("Twoim przeciwnikem jest mag na poziomie {0}!\nWciśnij dowolny przycisk by kontynuuować", przeciwnik.level);
                przeciwnik.lvl_up(gracz.level);
                Console.ReadKey();
                int i = 1;
                while (gracz.aktualne_hp > 0 && przeciwnik.aktualne_hp > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Runda {0}, masz {1} hp, przeciwnik ma {2} hp.\nWciśnij dowolny przycisk by kontynuować.", i, gracz.aktualne_hp, przeciwnik.aktualne_hp);
                    i++;
                    Console.ReadKey();
                    przeciwnik.aktualne_hp -= gracz.menu();
                    if (przeciwnik.aktualne_hp > 0)
                    {
                        gracz.aktualne_hp -= przeciwnik.si_fight();
                    }
                    else
                    {
                        continue;
                    }
                }
                if (gracz.aktualne_hp > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Wygrywasz!\nWciśnij dowolny przycisk by kontynuować.");
                    Console.ReadKey();
                    gracz.add_experience((przeciwnik.level + 1) * 50);
                    gracz.level_up();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Niestety tym razem się nie udało.\nWciśnij dowolny przycisk by kontynuować.");
                    Console.ReadKey();
                }
            }
            if (a == 3)
            {
                Console.Clear();
                Lucznik_SI przeciwnik = new Lucznik_SI();
                przeciwnik.lvl_up(gracz.level);
                Console.WriteLine("Twoim przeciwnikem jest Lucznik na poziomie {0}!\nWciśnij dowolny przycisk by kontynuuować", przeciwnik.level);
                Console.ReadKey();
                int i = 1;
                while (gracz.aktualne_hp > 0 && przeciwnik.aktualne_hp > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Runda {0}, masz {1} hp, przeciwnik ma {2} hp.\nWciśnij dowolny przycisk by kontynuować.", i, gracz.aktualne_hp, przeciwnik.aktualne_hp);
                    i++;
                    Console.ReadKey();
                    przeciwnik.aktualne_hp -= gracz.menu();
                    if (przeciwnik.aktualne_hp > 0)
                    {
                        gracz.aktualne_hp -= przeciwnik.si_fight();
                    }
                    else
                    {
                        continue;
                    }
                }
                if (gracz.aktualne_hp > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Wygrywasz!\nWciśnij dowolny przycisk by kontynuować.");
                    Console.ReadKey();
                    gracz.add_experience((przeciwnik.level + 1) * 50);
                    gracz.level_up();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Niestety tym razem się nie udało.\nWciśnij dowolny przycisk by kontynuować.");
                    Console.ReadKey();
                }
            }

        }
    }
}
