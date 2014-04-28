using System;

namespace Blackjack_Collected
{
	class MainClass
	{
		//private Deck deck; it's not being used <- we could just delete this
		//here we load the differnt things we want to run into the main
		static void Main()
		{
//			Player player = new Player ();
			Deck deck = new Deck();
			Hand hand = new Hand (); 
			deck.SetDeck();
			deck.Shuffle();

			deck.DispalyDeck();


//			deck.Deal(player.Hand);
			deck.Deal (hand);

			deck.DispalyDeck();
//			player.Hand.ShowHand ();
			hand.ShowHand ();
			Console.WriteLine (hand.HandValue);
			Console.ReadLine();
		}
	}
}
