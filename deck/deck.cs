using System.Collections.Generic;
using System;

namespace deck
{
    public class Deck
    {
        List<Card> cards;

        public Deck()
        {
            create();
            shuffle();
        }


        public Deck create()
        {
            cards = new List<Card>();
            string[] suits = {"Hearts", "Spades", "Diamonds", "Clubs"};
            string[] strVal = {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "Kind"};

            foreach (string suit in suits)
            {

                for (int i = 1; i<strVal.Length; i++)
                {
                    Card make =  new Card(strVal[i], suit, i+1);
                    cards.Add(make);
                }
                
            }
            return this;
        }

        public Deck shuffle()
        {
            Random rando = new Random();
            for ( int last = cards.Count-1; last>0; last--)
            {
                int randidx = rando.Next(last);
                Card temp = cards[randidx];

                cards [randidx] = cards[last];
                cards[last] = temp;
            }
            return this;
        }

        public List<Card> deal()
        {
            List<Card> give = new List<Card>();
            for (int i = 0; i<7; i++)
            {
                give.Add(cards[i]);
                cards.RemoveAt(i);
            }
            return give;
        }

        public Card getTop()
        {
            Card top = cards[0];
            cards.RemoveAt(0);
            return top;

        }
    }

}