using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    abstract class HeroesAndStwory
    {
        internal int aktualne_hp = 100;
        internal int level = 1;
        protected int sila = 5;
        protected int zrecznosc = 5;
        protected int inteligencja = 5;
        internal virtual void lvl_up(int poziom) { }
        internal virtual int si_fight()
        {
            return 0;
        }
    }
}
