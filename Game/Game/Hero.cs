using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    abstract class Hero
    {
        protected int level = 1;
        protected int experience = 0;
        protected int experience_to_next_lvl = 100;
        protected int aktualne_hp = 100;
        protected int max_hp = 100;
        protected int aktualna_mana = 100;
        protected int max_mana = 100;
        protected int sila = 5;
        protected int zrecznosc = 5;
        protected int inteligencja = 5;

        void add_experience(int exp_from_mission)
        {
            this.experience += exp_from_mission;
        }
        protected virtual void level_up()
        {
                Console.Clear();
                this.level += 1;
                this.experience = this.experience - experience_to_next_lvl;
                experience_to_next_lvl *= (level + 2);
                Console.WriteLine("Awansowałeś na kolejny lvl.\nAby kontynuować wciśnij dowolny przycisk.");
        }
        public virtual void ulecz()
        {
            if (aktualna_mana >= 30)
            {
                this.aktualne_hp += level * 25;
                this.aktualna_mana -= 30;
                Console.WriteLine("Uleczono {0} hp.\nWciśnij dowolny przycisk by kontynuować.", level * 25);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Za mało many!\nWciśnij dowolny przycisk by kontynuować.");
                Console.ReadKey();
            }
        }
        internal void odpocznij()
        {
            this.aktualne_hp = max_hp;
            this.aktualna_mana = max_mana;
        }
        internal abstract int atak();
    }
    class Wojownik : Hero
    {
        internal Wojownik() { this.aktualne_hp = 200; this.max_hp = 200; this.sila = 10;  }
        protected override void level_up()
        {
            if (experience >= experience_to_next_lvl)
            {
                base.level_up();
                this.sila += (level + 1) * 5;
                this.zrecznosc += level * 5;
                this.inteligencja += level * 5;
                this.max_hp += max_hp * (level + 4);
                this.max_mana += 15;
                this.aktualna_mana = max_mana;
                this.aktualne_hp = max_hp;
                Console.ReadKey();
            }
        }
        internal override int atak()
        {
            int obrazenia = 0;
            obrazenia = sila * (level + 3);
            Console.WriteLine("Zadano {0} obrażeń!", sila * (level + 3));
            return obrazenia;
        }
        internal int silny_atak()
        {
            int obrazenia = 0;
            obrazenia = sila * (level + 3) * 2;
            this.aktualna_mana -= 30;
            Console.WriteLine("Zadano {0} obrażeń!", sila * (level + 3) * 2);
            return obrazenia;
        }
        internal int oglusz()
        {
            int obrazenia = 0;
            obrazenia = sila * (level + 3);
            this.aktualna_mana -= 40;
            Console.WriteLine("Zadano {0} obrażeń i ogłuszono przeciwnika!", sila * (level + 3));
            return obrazenia;
        }

    }
     class Mag : Hero
     {
         internal Mag() { this.aktualna_mana = 200; this.max_mana = 200; this.inteligencja = 10; }
         protected override void level_up()
         {
             if (experience >= experience_to_next_lvl)
             {
                 base.level_up();
                 this.sila += level * 5;
                 this.zrecznosc += level * 5;
                 this.inteligencja += (level + 1) * 5;
                 this.max_hp += max_hp * (level + 1);
                 this.max_mana += 50;
                 this.aktualna_mana = max_mana;
                 this.aktualne_hp = max_hp;
                 Console.ReadKey();
             }
         }
         internal override int atak()
         {
             int obrazenia = 0;
             obrazenia = inteligencja * (level + 3);
             Console.WriteLine("Zadano {0} obrażeń!", inteligencja * (level  + 3));
             return obrazenia;
         }
        internal int kula_ognia()
        {
            int obrazenia = 0;
            obrazenia = inteligencja * (level * 5);
            this.aktualna_mana -= 30;
            Console.WriteLine("Zadano {0} obrażeń!", inteligencja * (level * 5));
            return obrazenia;
        }
        internal int zamroź()
        {
            int obrazenia = 0;
            obrazenia = inteligencja * level;
            this.aktualna_mana -= 50;
            Console.WriteLine("Zadano {0} obrażeń i zamrożono przeciwnika!", inteligencja * (level * 5));
            return obrazenia;
        }
     }
        class Lucznik : Hero
         {
            internal Lucznik() { this.aktualne_hp = 150; this.max_hp = 150; this.aktualna_mana = 150; this.max_mana = 150; this.zrecznosc = 10; }
            protected override void level_up()
            {
                if (experience >= experience_to_next_lvl)
                {
                     base.level_up();
                     this.sila += level * 5;
                     this.zrecznosc += (level + 1) * 5;
                     this.inteligencja += level * 5;
                     this.max_hp += max_hp * (level + 2);
                     this.max_mana += 30;
                     this.aktualna_mana = max_mana;
                     this.aktualne_hp = max_hp;
                     Console.ReadKey();
                }
            }
            internal override int atak()
            {
                 int obrazenia = 0;
                 obrazenia = zrecznosc * (level + 3);
                 Console.WriteLine("Zadano {0} obrażeń!", zrecznosc * (level + 3));
                 return obrazenia;
            }
            internal int head_shot()
            {
                int obrazenia = 0;
                obrazenia = zrecznosc * (level + 3);
                this.aktualna_mana -= 40;
                Console.WriteLine("Zadano {0} obrażeń!", zrecznosc * (level + 3));
                return obrazenia;
            }
            internal int mocny_strzal()
            {
                 int obrazenia = 0;
                 obrazenia = zrecznosc * (level + 3) * 2;
                 this.aktualna_mana -= 25;
                 Console.WriteLine("Zadano {0} obrażeń!", zrecznosc * (level + 3) * 2);
                 return obrazenia;
             }
        }
}
