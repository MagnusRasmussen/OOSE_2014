using System;

namespace Blackjack_Collected
{
	class MainClass
	{
		//private Deck deck; it's not being used <- we could just delete this
		//here we load the differnt things we want to run into the main
		static void Main()
		{
			Deck deck = new Deck();
			deck.SetDeck();
			deck.Shuffle();
			deck.DispalyDeck();

		}
	}
}
