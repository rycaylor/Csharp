namespace  go_fish
{
    public class PlayGoFish
    {
            public Deck gameDeck = new Deck();
            public HumanPlayer p1 = new HumanPlayer();
            public HumanPlayer p2 = new HumanPlayer();
            public HumanPlayer p3 = new HumanPlayer();
            public HumanPlayer p4 = new HumanPlayer();
            public bool isGame;
        public PlayGoFish()
        {
            System.Console.WriteLine("Who is player 1?");
            this.p1.name = System.Console.ReadLine();
            System.Console.WriteLine("Who is player 2?");
            this.p2.name = System.Console.ReadLine();
            System.Console.WriteLine("Who is player 3?");
            this.p3.name = System.Console.ReadLine();
            System.Console.WriteLine("Who is player 4?");
            this.p4.name = System.Console.ReadLine();
            System.Console.WriteLine("***********************");
            System.Console.WriteLine("***********************");
            System.Console.WriteLine("***********************");
            System.Console.WriteLine("*****Play Go Fish******");
            System.Console.WriteLine("***********************");
            System.Console.WriteLine("***********************");
            System.Console.WriteLine("***********************");

        }

        public void Play(){
            isGame = true;
            bool handGot = true;
            while(isGame){
                if (handGot){
                this.p1.getHand(gameDeck);
                this.p2.getHand(gameDeck);
                this.p3.getHand(gameDeck);
                this.p4.getHand(gameDeck);
                handGot = false;
                }

                bool turn1 = true;
                bool turn2 = false;
                bool turn3 = false;
                bool turn4 = false;
                while(turn1)
                {   
                    System.Console.WriteLine(this.p1.name + " your score is " + this.p1.score);
                    System.Console.WriteLine(p1.name + " it's your turn, here are your cards:");
                    foreach(Card card in p1.hand){
                        System.Console.WriteLine(card.stringVal);
                    }
                    System.Console.WriteLine("Who do you want to ask?");
                    string target = System.Console.ReadLine();
                    
                    if (target == this.p2.name)
                    {
                        System.Console.WriteLine("What fish are you fishing for");
                        string fish = System.Console.ReadLine();
                        bool end = false;
                        for ( int i = p2.hand.Count-1; i>0; i--)
                        { 
                            if(fish == p2.hand[i].stringVal)
                            {
                                this.p1.hand.Add(p2.hand[i]);
                                System.Console.WriteLine("you got " + p2.hand[i].stringVal);
                                this.p2.hand.Remove(p2.hand[i]);
                                if (this.p1.checkBook())
                                {
                                    this.p1.score += 1;
                                }
                            }
                            
                            
                        }
                    if (end == true){
                                System.Console.WriteLine("Go Fish!");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("*********** Next Turn ************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                this.p1.draw(gameDeck);
                                if (this.p1.checkBook())
                                {
                                    this.p1.score += 1;
                                }
                                turn1 = false;
                                turn2 = true;
            
                        }
                    }

                    else if (target == this.p3.name)
                    {
                        System.Console.WriteLine("What fish are you fishing for");
                        string fish = System.Console.ReadLine();
                        bool end = false;
                        for ( int i = p3.hand.Count-1; i>0; i--)
                        { 
                            if(fish == p3.hand[i].stringVal)
                            {
                                this.p1.hand.Add(p3.hand[i]);
                                System.Console.WriteLine("you got" + p3.hand[i].stringVal);
                                this.p3.hand.Remove(p3.hand[i]);
                                if (this.p1.checkBook())
                                {
                                    this.p1.score += 1;
                                }
                            }
                            else {
                                end = true;
                            }
                        }
                        if (end == true){
                                System.Console.WriteLine("Go Fish!");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("*********** Next Turn ************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                this.p1.draw(gameDeck);
                                if (this.p1.checkBook())
                                {
                                    this.p1.score += 1;
                                }
                                turn1 = false;
                                turn2 = true;
                            }
                        }
                    
                    else if (target == this.p4.name)
                    {
                        System.Console.WriteLine("What fish are you fishing for");
                        string fish = System.Console.ReadLine();
                        bool end = false;
                        for ( int i = p4.hand.Count-1; i>0; i--)
                        { 
                            if(fish == p4.hand[i].stringVal)
                            {
                                this.p1.hand.Add(p4.hand[i]);
                                System.Console.WriteLine("you got" + p4.hand[i].stringVal);
                                this.p4.hand.Remove(p4.hand[i]);
                                if (this.p1.checkBook())
                                {
                                    this.p1.score += 1;
                                }
                            }
                            else 
                            {
                                end = true;
                            }
                        }
                        if (end == true){
                                System.Console.WriteLine("Go Fish!");
                                 System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("*********** Next Turn ************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                this.p1.draw(gameDeck);
                                if (this.p1.checkBook())
                                {
                                    this.p1.score += 1;
                                }
                                turn1 = false;
                                turn2 = true;
                            }
                        }
                    
                    else{
                        System.Console.WriteLine("Not a player try again");
                    }
                    
                }
                while(turn2)
                {   
                    System.Console.WriteLine(this.p2.name + " your score is " + this.p2.score);
                    System.Console.WriteLine(p2.name + " it's your turn, here are your cards:");
                    foreach(Card card in p2.hand){
                        System.Console.WriteLine(card.stringVal);
                    }
                    System.Console.WriteLine("Who do you want to ask?");
                    string target = System.Console.ReadLine();
                    
                    if (target == this.p1.name)
                    {
                        bool end = false;
                        System.Console.WriteLine("What fish are you fishing for");
                        string fish = System.Console.ReadLine();
                        
                        for ( int i = p1.hand.Count-1; i>0; i--)
                        { 
                            if(fish == p1.hand[i].stringVal)
                            {
                                this.p2.hand.Add(p1.hand[i]);
                                System.Console.WriteLine("you got" + p1.hand[i].stringVal);
                                this.p1.hand.Remove(p1.hand[i]);
                                if (this.p2.checkBook())
                                {
                                    this.p2.score += 1;
                                }
                            }
                            else{
                                end = true;
                            }
                        }
                        if (end == true){
                                System.Console.WriteLine("Go Fish!");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("*********** Next Turn ************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                this.p2.draw(gameDeck);
                                if (this.p2.checkBook())
                                {
                                    this.p2.score += 1;
                                }
                                turn2 = false;
                                turn3 = true;
                            }
                        }
                    

                    else if (target == this.p3.name)
                    {
                        System.Console.WriteLine("What fish are you fishing for");
                        string fish = System.Console.ReadLine();
                        bool end = false;
                        for ( int i = p3.hand.Count-1; i>0; i--)
                        { 
                            if(fish == p3.hand[i].stringVal)
                            {
                                this.p2.hand.Add(p3.hand[i]);
                                System.Console.WriteLine("you got" + p3.hand[i].stringVal);
                                this.p3.hand.Remove(p3.hand[i]);
                                if (this.p2.checkBook())
                                {
                                    this.p2.score += 1;
                                }
                            }
                            else{
                                end = true;
                            }
                        }
                        if (end == true){
                                System.Console.WriteLine("Go Fish!");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("*********** Next Turn ************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                this.p2.draw(gameDeck);
                                if (this.p2.checkBook())
                                {
                                    this.p2.score += 1;
                                }
                                turn2 = false;
                                turn3 = true;
                            }
                        }
                    
                    else if (target == this.p4.name)
                    {
                        System.Console.WriteLine("What fish are you fishing for");
                        string fish = System.Console.ReadLine();
                        bool end = false;
                        for ( int i = p4.hand.Count-1; i>0; i--)
                        { 
                            if(fish == p4.hand[i].stringVal)
                            {
                                this.p2.hand.Add(p4.hand[i]);
                                System.Console.WriteLine("you got" + p4.hand[i].stringVal);
                                this.p4.hand.Remove(p4.hand[i]);
                                if (this.p2.checkBook())
                                {
                                    this.p2.score += 1;
                                }
                            }
                            else{
                                end = true;
                            }
                        }
                        if (end == true){
                                System.Console.WriteLine("Go Fish!");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("*********** Next Turn ************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                this.p2.draw(gameDeck);
                                if (this.p2.checkBook())
                                {
                                    this.p2.score += 1;
                                }
                                turn2 = false;
                                turn3 = true;
                            }
                        }
                    
                    else{
                        System.Console.WriteLine("Not a player try again");
                    }
                
                }
                while(turn3)
                {   
                    System.Console.WriteLine(this.p3.name + " your score is " + this.p3.score);
                    System.Console.WriteLine(p3.name + " it's your turn, here are your cards:");
                    foreach(Card card in p3.hand){
                        System.Console.WriteLine(card.stringVal);
                    }
                    System.Console.WriteLine("Who do you want to ask?");
                    string target = System.Console.ReadLine();
                    
                    if (target == this.p1.name)
                    {
                        System.Console.WriteLine("What fish are you fishing for");
                        string fish = System.Console.ReadLine();
                        bool end = false;
                        for ( int i = p1.hand.Count-1; i>0; i--)
                        { 
                            if(fish == p1.hand[i].stringVal)
                            {
                                this.p3.hand.Add(p1.hand[i]);
                                System.Console.WriteLine("you got" + p1.hand[i].stringVal);
                                this.p1.hand.Remove(p1.hand[i]);
                                if (this.p3.checkBook())
                                {
                                    this.p3.score += 1;
                                }
                            }
                            else{
                                end = true;
                            }
                        }
                        if (end == true){
                                System.Console.WriteLine("Go Fish!");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("*********** Next Turn ************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                this.p3.draw(gameDeck);
                                if (this.p3.checkBook())
                                {
                                    this.p3.score += 1;
                                }
                                turn3 = false;
                                turn4 = true;
                            }
                        }
                    

                    else if (target == this.p2.name)
                    {
                        System.Console.WriteLine("What fish are you fishing for");
                        string fish = System.Console.ReadLine();
                        bool end = false;
                        for ( int i = p2.hand.Count-1; i>0; i--)
                        { 
                            if(fish == p2.hand[i].stringVal)
                            {
                                this.p3.hand.Add(p2.hand[i]);
                                System.Console.WriteLine("you got" + p2.hand[i].stringVal);
                                this.p2.hand.Remove(p2.hand[i]);
                                if (this.p3.checkBook())
                                {
                                    this.p3.score += 1;
                                }
                            }
                            else{
                                end = true;
                            }
                        }
                        if (end == true){
                                System.Console.WriteLine("Go Fish!");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("*********** Next Turn ************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                this.p3.draw(gameDeck);
                                if (this.p3.checkBook())
                                {
                                    this.p3.score += 1;
                                }
                                turn3 = false;
                                turn4 = true;
                            }
                        }
                    
                    else if (target == this.p4.name)
                    {
                        System.Console.WriteLine("What fish are you fishing for");
                        string fish = System.Console.ReadLine();
                        bool end = false;
                        for ( int i = p4.hand.Count-1; i>0; i--)
                        { 
                            if(fish == p4.hand[i].stringVal)
                            {
                                this.p3.hand.Add(p4.hand[i]);
                                System.Console.WriteLine("you got" + p4.hand[i].stringVal);
                                this.p4.hand.Remove(p4.hand[i]);
                                if (this.p3.checkBook())
                                {
                                    this.p3.score += 1;
                                }
                            }
                            else {
                                end = true;
                            }
                        }
                        if (end == true){
                                System.Console.WriteLine("Go Fish!");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("*********** Next Turn ************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                this.p3.draw(gameDeck);
                                if (this.p3.checkBook())
                                {
                                    this.p3.score += 1;
                                }
                                turn3 = false;
                                turn4 = true;
                            }
                        }
                    
                    else{
                        System.Console.WriteLine("Not a player try again");
                    }
                }
                while(turn4)
                {   
                    System.Console.WriteLine(this.p4.name + " your score is " + this.p4.score);
                    System.Console.WriteLine(p4.name + " it's your turn, here are your cards:");
                    foreach(Card card in p4.hand){
                        System.Console.WriteLine(card.stringVal);
                    }
                    System.Console.WriteLine("Who do you want to ask?");
                    string target = System.Console.ReadLine();
                    
                    if (target == this.p1.name)
                    {
                        System.Console.WriteLine("What fish are you fishing for");
                        string fish = System.Console.ReadLine();
                        bool end = false;
                        for ( int i = p1.hand.Count-1; i>0; i--)
                        { 
                            if(fish == p1.hand[i].stringVal)
                            {
                                this.p4.hand.Add(p1.hand[i]);
                                System.Console.WriteLine("you got" + p1.hand[i].stringVal);
                                this.p1.hand.Remove(p1.hand[i]);
                                if (this.p4.checkBook())
                                {
                                    this.p4.score += 1;
                                }
                            }
                            else {
                                end = true;
                            }
                        }
                        if (end == true){
                                System.Console.WriteLine("Go Fish!");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("*********** Next Turn ************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                this.p4.draw(gameDeck);
                                if (this.p4.checkBook())
                                {
                                    this.p4.score += 1;
                                }
                                turn4 = false;
                                turn1 = true;
                            }
                        }
                    

                    else if (target == this.p2.name)
                    {
                        System.Console.WriteLine("What fish are you fishing for");
                        string fish = System.Console.ReadLine();
                        bool end = false;
                        for ( int i = p2.hand.Count-1; i>0; i--)
                        { 
                            if(fish == p2.hand[i].stringVal)
                            {
                                this.p4.hand.Add(p2.hand[i]);
                                System.Console.WriteLine("you got" + p2.hand[i].stringVal);
                                this.p2.hand.Remove(p2.hand[i]);
                                if (this.p4.checkBook())
                                {
                                    this.p4.score += 1;
                                }
                            }
                            else{
                                end = true;
                            }
                        }
                        if (end == true){
                                System.Console.WriteLine("Go Fish!");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("*********** Next Turn ************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                this.p4.draw(gameDeck);
                                if (this.p4.checkBook())
                                {
                                    this.p4.score += 1;
                                }
                                turn4 = false;
                                turn1 = true;
                            }
                        }
                    
                    else if (target == this.p3.name)
                    {
                        System.Console.WriteLine("What fish are you fishing for");
                        string fish = System.Console.ReadLine();
                        bool end = false;
                        for ( int i = p3.hand.Count-1; i>0; i--)
                        { 
                            if(fish == p3.hand[i].stringVal)
                            {
                                this.p4.hand.Add(p3.hand[i]);
                                System.Console.WriteLine("you got" + p3.hand[i].stringVal);
                                this.p3.hand.Remove(p3.hand[i]);
                                if (this.p4.checkBook())
                                {
                                    this.p4.score += 1;
                                }
                            }
                            else {
                                end = true;
                            }
                        }
                        if (end == true){
                                System.Console.WriteLine("Go Fish!");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("*********** Next Turn ************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                System.Console.WriteLine("**********************************");
                                this.p4.draw(gameDeck);
                                if (this.p4.checkBook())
                                {
                                    this.p4.score += 1;
                                }
                                turn4 = false;
                                turn1 = true;
                            }
                        }
                    
                    else{
                        System.Console.WriteLine("Not a player try again");
                    }
                }

                if (this.p1.hand.Count == 0 && this.p2.hand.Count == 0 && this.p3.hand.Count == 0 && this.p4.hand.Count == 0){
                    System.Console.WriteLine(this.p1.name + this.p1.score);
                    System.Console.WriteLine(this.p2.name + this.p2.score);
                    System.Console.WriteLine(this.p3.name + this.p3.score);
                    System.Console.WriteLine(this.p4.name + this.p4.score);
                    isGame=false;
                }
                //gameshitgoeshere

            }
        }
    }
}