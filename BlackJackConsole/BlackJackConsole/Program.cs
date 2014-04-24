using System;


namespace BlackJackConsole
{
    class MainClass
    {
        private Deck deck;


        static void Main()
        {
            Deck deck = new Deck();
            deck.SetDeck();
            deck.Shuffle();
            deck.DispalyDeck();

        }
    }


}


