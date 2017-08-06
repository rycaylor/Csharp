using System;

namespace humans
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human Ryan = new Human("Ryan");
            Human Brandon = new Human("Brandon");
            Ryan.Edit("Ryan", 8, 10, 10, 100);
            Ryan.Attack(Brandon);
            System.Console.WriteLine(Ryan.name +  " attacks " + Brandon.name + " with a strength of " + Ryan.strength + " Brandon's helath goes to "  + Brandon.health);
            Brandon.Edit("Brandon", 15, 10, 10, 60);
            Brandon.Attack(Ryan);
            System.Console.WriteLine(Brandon.name + " counters with a devastating " +Brandon.strength + " strength power dropping Ryan to " + Ryan.health);
            Human Kyle = new Human("Kyle");
            Kyle.Edit("Kyle", 1,1,1,0);
            System.Console.WriteLine(Kyle.name + " enters the dojo only to get hit by both Ryan and Brandons attack taking Kyle's HP to " + Kyle.health);

        }
    }
}
