using System;


namespace BlackJackConsole
{
	class MainClass
	{
		private Deck deck;
	
		 
		 static void Main ()
		{
			Deck deck = new Deck ();
			deck.SetDeck (); 


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
			//			int i;
			//			int j;
			//
			//			for (i = 1; i < 52; i++)
			//			{
			//				for (j = 1; j < 2; j++)  
			//				{
			//				
			//					Console.Write (deck.cards);
			//					}
			//				Console.WriteLine();
			//					}
			foreach (var tal in deck.cards) {
				Console.WriteLine (deck.cards);
				Console.ReadLine ();
			}
		}

	}

}

