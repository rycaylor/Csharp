namespace wizard
{
    public class  Human
    {
        public string name {get; set;}
        public int strength {get; set;}
        public int intelligence {get; set;}
        public int dexterity {get; set;}
        public int health {get; set;}


        public void Edit(string names, int str, int intel, int dext, int hp)
        {
            name = names;
            strength = str;
            intelligence =intel;
            dexterity = dext;
            health = hp;
        }

        public void Attack(object person)
        {
            Human target = person as Human;
            int attpwr = 5 * strength;
            target.health -= attpwr;
            
        }

    }

}