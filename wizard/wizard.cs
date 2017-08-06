using System;
using System.Collections.Generic;


namespace wizard
{
    public class Wizard : Human
    {
        public string name;
        public int health = 50;
        public  int intelligence = 25;

        public Wizard(string name, int health, int intelligence)
        {
            this.name = name;
            this.health = health;
            this.intelligence = intelligence;
        }

        public void fireball(object target)
        {
            Random rando = new Random();
            int dmg = rando.Next(20,51);
            Human enemy = target as Human;
            enemy.health -= dmg;
        }

        public void heal()
        {
            int heal = this.intelligence *10;
            this.health += heal;
        }


    }
}