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
}
