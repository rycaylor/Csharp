using System.Collections.Generic;
using System;


namespace go_fish
{
    public class Deck 
    {
        public Deck()
        {
            reset();
            shuffle();
        }
        public  List<Card> cards;
        public Deck reset()
        {   
            cards = new List<Card>();
            string[] suits = {"1", "2", "3", "4", "5", "6", "7", "8"};
            string[] strVals = {"Salmon", "Trout", "Halibut", "Pike", "Sturgeon", "Tilapia", "Flounder", "Swordfish", "Tuna", "Guppy", "Rockfish", "CatFish", "DogFish"};
            foreach (string suit in suits)
            {
                for ( int i = 0; i<strVals.Length; i++)
                {
                    Card newCard = new Card(strVals[i], suit, i+1);
                    cards.Add(newCard);
                }
            }
            return this;
        }

        public Deck shuffle()
        { 
            Random rando = new Random();
            for (int end = cards.Count-1; end>0; end--)
            {
                int randex = rando.Next(end);

                Card temp = cards[randex];

                cards[randex] = cards[end];
                cards[end] = temp;
            }
            return this;
        }

        public List<Card> deal()
        {
            List<Card> res = new List<Card>();
            for ( int i = 0; i < 7; i++)
            {
                res.Add(cards[i]);
                cards.RemoveAt(i);
            }
            return res;
        }

        public Card getTop(){
            
            Card top = cards[0];
            cards.RemoveAt(0);
            return top;
            
            
        }

    }
}