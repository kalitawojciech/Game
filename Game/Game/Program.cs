using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static internal List<string> nazwa_misji = new List<string>();
        static internal List<string> opis_misji = new List<string>();
        static internal List<HeroesAndStwory> lista = new List<HeroesAndStwory>();
        static void Main(string[] args)
        {
            nazwa_misji.Add("Polowanie na wilki.");
            opis_misji.Add("Pewien wilk zjada kury z mojej farmy. Zabij go dla mnie a nie poszczędzę grosza");
            lista.Add(new Wilk());
            Menu.menu();
        }
    }
}
