namespace humans
{
    public class  Human
    {
        public string name;
        public int strength = 3;
        public int intelligence = 3;
        public int dexterity = 3;
        public int health = 100;

        public Human(string nam)
        {
            name = nam;
        }

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