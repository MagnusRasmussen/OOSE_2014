using System;

namespace Blackjack_Collected
{
	class MainClass
	{
		//private Deck deck; it's not being used <- we could just delete this
		//here we load the differnt things we want to run into the main
		static void Main()
		{
			Player player = new Player ();
			Dealer dealer = new Dealer ();
			Deck deck = new Deck();
			Hand hand = new Hand ();
			Betting betting = new Betting ();

//			deck.SetDeck();
//			deck.Shuffle();
//
//			deck.DispalyDeck();
//
//			deck.Deal (player.Hand);

//			deck.Deal (player.Hand);
//			deck.Deal (dealer.Hand);
			//deck.Deal (hand);

//			deck.DispalyDeck();
//			player.Hand.ShowHand ();
//			player.Hand.ShowHand ();
//			deck.DrawCard(player.Hand);
//			deck.DispalyDeck();
			Console.WriteLine (player.Hand.HandValue);
			Console.WriteLine (dealer.Hand.HandValue);

			betting.checkForWin (player.Hand.HandValue, dealer.Hand.HandValue);


			Console.ReadLine();
		}
	}
}
