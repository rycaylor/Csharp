using System.Collections.Generic;
using System;
namespace go_fish
{
    public class HumanPlayer
    {
        public List<Card> hand;
        public List<Card> book;
        // public list<Deck> deck;
        public int score = 0;
        public string name;
        public HumanPlayer(){
            this.hand = new List<Card>();
            this.name = "";
            this.score = 0;
            this.book = new List<Card>();
        }
        public List<Card> getHand(Deck deck)
        {
            List<Card> cards = deck.deal();
            foreach(Card card in cards)
            {
                this.hand.Add(card);
            }
            return this.hand;
        }

        public bool checkBook()
        {
            Dictionary<string, int> bookDict = new Dictionary<string, int>();
            foreach(Card card in this.hand){
                if(bookDict.ContainsKey(card.stringVal)){
                    // bookDict[card.stringVal].Value ++;
                    bookDict[card.stringVal] +=1;
                }
                else{
                    bookDict.Add(card.stringVal, 1);
                }
            }
            foreach(var pair in bookDict){
                // for(int i = bookDict.Count; i >= 0; i--){
                if(pair.Value >= 4){
                    // if(bookDict[i].Value)
                    int count = 0;
                    while(count < 4){
                        // foreach(Card card in this.hand){
                        //     this.hand.Remove(card);
                        //     count += 1;
                        for (int i = hand.Count-1; i>0;i-- ){
                            this.hand.RemoveAt(i);
                            count +=1;
                        }
                    }
                    return true;
                }
            }
            return false;
        }

        public bool draw(Deck deck)
        {
            if( deck.cards.Count >0)
            {
                Card newCard = deck.getTop();
                this.hand.Add(newCard);
                return true;
            }
            else{
                System.Console.WriteLine("no cards");
                return false;
            }

        }
    }
}