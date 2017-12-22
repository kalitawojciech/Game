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
            karczma.bohater = gracz;
            Wojownik enemy = new Wojownik();
            //Miasto.menu(arena, karczma);
            enemy.aktualne_hp = 500;
            Console.WriteLine(enemy.aktualne_hp);
            Console.ReadKey();
            enemy.aktualne_hp -= gracz.menu();
            Console.WriteLine(enemy.aktualne_hp);

            Console.ReadKey();
            gracz.aktualne_hp -= enemy.menu();
            Console.WriteLine(enemy.aktualne_hp);
            Console.ReadKey();
           /* while (enemy.aktualne_hp > 0)
            {
                enemy.aktualne_hp -= gracz.menu();
                Console.WriteLine(enemy.aktualne_hp);
                Console.ReadKey();
            }
            Console.ReadKey(); */
        }
    }
}
