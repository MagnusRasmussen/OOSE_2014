using System;


namespace BlackJackConsole
{
	class MainClass
	{
		private Deck deck;
	
		 
		 static void Main ()
		{
            Deck deck = new Deck();
            deck.SetDeck();
            deck.Shuffle();
            deck.DispalyDeck();


		}

//		public void ShowDeck()
//		{
//			deck.SetDeck ();
//		}

		public void WriteToConsole()
		{

		}

		public void DisplayDeck ()
		{
            int i;
            //int j;

            for (i = 1; i < 52; i++)
            {
                //for (j = 1; j < 2; j++)
                //{
                    var card = deck.cards[i];
                    Console.WriteLine(card.Suite + " " + card.Rank);
                    Console.ReadLine();
                //}
                //Console.WriteLine();
            }
            //foreach (var tal in deck.cards) {
            //    Console.WriteLine (deck.cards);
            //    Console.ReadLine ();
			}
        
		}

	}

//}

