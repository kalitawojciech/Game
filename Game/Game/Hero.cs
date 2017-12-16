﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Hero
    {
        int level = 1;
        int experience = 0;
        int experience_to_next_lvl = 100;
        int aktualne_hp;
        int max_hp;
        int aktualna_mana;
        int max_mana;
        int sila;
        int zrecznosc;
        int inteligencja;

        void add_experience(int exp_from_mission)
        {
            this.experience += exp_from_mission;
        }
        public virtual void level_up()
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
            this.aktualne_hp += level * 25;
            this.aktualna_mana -= 30;
        }
    }
}
