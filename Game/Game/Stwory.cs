using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    abstract class Stwory
    {
        internal int level = 1;
        internal int aktualne_hp = 100;
        protected int aktualna_mana = 0;
        protected int sila = 5;
        protected int zrecznosc = 5;
        protected int inteligencja = 5;
        protected abstract int atak();
        internal abstract void lvl_up(int lvl);
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
        internal override void lvl_up(int lvl)
        {
            if (level > 1)
            {
                this.level = lvl;
                this.sila *= (lvl + 2);
                this.zrecznosc *= (lvl * 4);
                this.aktualne_hp *= lvl + 3;
            }
        }
        internal int fight_menu()
        {
            return atak();
        }
    }
}
