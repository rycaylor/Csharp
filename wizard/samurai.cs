using System;
using System.Collections.Generic;

namespace wizard
{
    public class Samurai:Human
    {
        string name;
        int health;

        public Samurai(string name)
        {
            this.name = name;
            this.health = 200;

        }


        public void deathSweep(object target)
        {
            Human enemy = target as Human;
            if ( enemy.health <= 50)
            {
                enemy.health = 0;
            }
            else
            {
                System.Console.WriteLine("This samurai focused its strength to perform a death sweep but missed decreasing its health by 80");
                this.health -= 80;
            }
        }


        public void meditate()
        {
            Random rando = new Random();
            int roll = rando.Next(0,2);
            if(roll == 0)
            {
                this.health = 200;
            }
            else
            {
                System.Console.WriteLine("The samurai tried to gether himself but became disrupted and was unable to calm his senses.");
            }
        }

    }
}