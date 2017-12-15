using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Hero
    {
        int level;
        int experience;
        int experience_to_next_lvl = 100;
        int hp;
        int mana;
        int sila;
        int zrecznosc;
        int inteligencja;

        void add_experience(int exp_from_mission)
        {
            this.experience += exp_from_mission;
        }
        void level_up()
        {
            if(experience >= experience_to_next_lvl)
            {
                this.level += 1;
                this.experience = experience_to_next_lvl - experience;
                experience_to_next_lvl *= (level + 2);
            }
        }
        public virtual void ulecz()
        {
            this.hp += 50;
            this.mana -= 30;
        }
    }
}
