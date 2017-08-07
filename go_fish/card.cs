namespace go_fish
{
        public class Card 
    {
        public string stringVal;
        string suit;
        int val;
        public Card(string name, string suitType, int value)
        {
            this.stringVal = name;
            this.suit = suitType;
            this.val = value;
        }
    }
}