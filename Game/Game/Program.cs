using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Wojownik gracz = new Wojownik();
            Karczma karczma = new Karczma();
            Arena arena = new Arena();
            arena.arena = arena;
            arena.karczma = karczma;
            karczma.karczma = karczma;
            karczma.arena = arena;
            //    Miasto.menu(arena, karczma);
            Mag mag = new Mag();
            while(gracz.aktualne_hp > 0)
            {
                gracz.aktualne_hp -= mag.atak();
                Console.WriteLine(gracz.aktualne_hp);
            }
            gracz.aktualne_hp = 200;
            while (gracz.aktualne_hp > 0)
            {
                gracz.aktualne_hp -= mag.kula_ognia();
                Console.WriteLine(gracz.aktualne_hp);
            }
            Console.ReadKey();
        }
    }
}
