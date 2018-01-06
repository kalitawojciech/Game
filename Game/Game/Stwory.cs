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
        internal abstract void lvl_up();
    }
    class Wilk : Stwory
    {
        internal Wilk(int level) { this.level = level; this.aktualne_hp = 250; }

        protected override int atak()
        {
            Console.Clear();
            int obrazenia;
            obrazenia = level * (sila + zrecznosc) * 2;
            Console.WriteLine("Wilk zadaje Ci {0} obrażeń.\nWciśnij dowolny przycisk by kontynuować.", obrazenia);
            Console.ReadKey();
            return obrazenia;
        }
        internal override void lvl_up()
        {
            this.sila *= (level + 4);
            this.zrecznosc *= (level * 4);
            this.aktualne_hp *= 2 * level + 5;
        }
        internal void fight_menu()
        {
            atak();
        }
    }
}
