using System;

namespace Blackjack_Collected
{
	class MainClass
	{
		//private Deck deck; it's not being used

		static void Main()
		{
			Deck deck = new Deck();
			deck.SetDeck();
			deck.Shuffle();
			deck.DispalyDeck();

		}
	}
}
