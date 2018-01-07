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
        private int experience_from_mission = 0;
        internal Mission(Hero gracz) { this.gracz = gracz; }
        internal void do_mission()
        {
            Console.Clear();
            Console.WriteLine(Program.opis_misji[gracz.wykonane_misje] + "\n\n1 - podejmij się misji\npozostałe przyciski - powrót");
            ConsoleKeyInfo cki;
            cki = Console.ReadKey();
            if(cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.NumPad1)
            {
                Walka_vs_Stwory walka = new Walka_vs_Stwory(gracz);
                walka.walka();
            }
            Console.ReadKey();
        }
        
    }
}
