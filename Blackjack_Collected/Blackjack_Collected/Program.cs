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

			deck.SetDeck();
			deck.Shuffle();
//
//			deck.DispalyDeck();
//
			deck.Deal (player.Hand);

//			deck.Deal (player.Hand);
			deck.Deal (dealer.Hand);
			//deck.Deal (hand);

//			deck.DispalyDeck();
//			player.Hand.ShowHand ();
			player.Hand.ShowHand ();
//			deck.DrawCard(player.Hand);
//			deck.DispalyDeck();
			Console.WriteLine (player.Hand.HandValue);
			//Console.WriteLine (dealer.Hand.HandValue);
			Console.WriteLine ((int)dealer.Hand.cards[0].Rank); // Only shows dealers first card

			//betting.checkForWin (player.Hand.HandValue, dealer.Hand.HandValue);



			while (true) {
				var key = Console.ReadKey (true);

				switch (key.Key) {
				case ConsoleKey.S: // Stand
					while (dealer.Hand.HandValue < 17)
					{
						deck.DrawCard (dealer.Hand);
					}
					betting.checkForWin (player.Hand.HandValue, dealer.Hand.HandValue);
					break;
				case ConsoleKey.D: // Draw
					deck.DrawCard (player.Hand);
					player.Hand.ShowHand ();
					Console.WriteLine (player.Hand.HandValue);
					betting.checkForBust (player.Hand.HandValue, false);
					break;
				default:
					break;
				}
			}
			//Console.ReadLine();
		}
	}
}
