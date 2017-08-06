using System;
using System.Collections.Generic;


namespace wizard
{
    public class Ninja : Human
    {
        string name;
        int health;
        int dexterity;

        public Ninja(string name, int health, int dexterity)
        {
            this.name = name;
            this.health = health;
            this.dexterity = dexterity;

        }

        public void steal(object target)
        {
            Human enemy = target as Human;
            this.Attack(enemy);
            this.health += 10;
        }

        public void getAway()
        {
            this.health -= 5;
        }
    }
}