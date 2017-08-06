using System;
using System.Collections.Generic;

namespace deck
{
    public class Player
    {
        string name;
        List<Card> hand;

        public List<Card> gethand(Deck deck)
        {
            List<Card> cards = deck.deal();
            foreach(Card card in cards)
            {
                this.hand.Add(card);
            }
            return this.hand;
        }

        public List<Card> draw(Deck deck)
        {
            Card top = deck.getTop();
            this.hand.Add(top);
            return this.hand;
        }

        public List<Card> discard(int val)
        {
            this.hand.RemoveAt(val);
            return this.hand;
        }
    }
}