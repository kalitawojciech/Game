using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    abstract class Stwory : HeroesAndStwory
    {
        protected int aktualna_mana = 0;
        protected abstract int atak();
    }
    class Wilk : Stwory
    {
        internal Wilk() {this.aktualne_hp = 250; }

        protected override int atak()
        {
            Console.Clear();
            int obrazenia;
            obrazenia = level * (sila + zrecznosc);
            Console.WriteLine("Wilk zadaje Ci {0} obrażeń.\nWciśnij dowolny przycisk by kontynuować.", obrazenia);
            Console.ReadKey();
            return obrazenia;
        }
        internal override void lvl_up(int poziom)
        {
            if (level > 1)
            {
                this.level = poziom;
                this.sila *= (poziom + 2);
                this.zrecznosc *= (poziom * 4);
                this.aktualne_hp *= poziom + 3;
            }
        }
        public int si_fight()
        {
            return atak();
        }
    }
}
