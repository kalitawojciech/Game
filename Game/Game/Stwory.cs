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
    class Wilk : Stwory, IamSI
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
        public void lvl_up(int lvl)
        {
            if (level > 1)
            {
                this.level = lvl;
                this.sila *= (lvl + 2);
                this.zrecznosc *= (lvl * 4);
                this.aktualne_hp *= lvl + 3;
            }
        }
        public int si_fight()
        {
            return atak();
        }
    }
}
