using System;

namespace Blackjack_Collected
{
	class MainClass
	{
		static void Main()
		{
			Player player = new Player ();
			Dealer dealer = new Dealer ();
			Deck deck = new Deck();
			Hand hand = new Hand ();
			Betting betting = new Betting ();

			int playerMoney = 500;
			int bet = 0;

			deck.SetDeck();
			deck.Shuffle();

			#region DisplayDeck
//			deck.DispalyDeck();
			#endregion

			betting.calcBet (playerMoney, bet);

			deck.Deal (player.Hand);
			deck.Deal (player.Hand);

			deck.Deal (dealer.Hand);

			player.Hand.ShowHand ();

			Console.WriteLine (player.Hand.HandValue);
			Console.WriteLine ((int)dealer.Hand.cards[0].Rank); // Only shows dealers first card
	
			while (true) {
				var key = Console.ReadKey (true);
			

				switch (key.Key) {
				case ConsoleKey.S: // Stand
					while (dealer.Hand.HandValue < 17 && dealer.Hand.HandValue < player.Hand.HandValue) {
						deck.DrawCard (dealer.Hand);
					}

					betting.stand = true;
					//betting.checkForBust (player.Hand.HandValue, dealer.Hand.HandValue);
					betting.checkForWin (player.Hand.HandValue, dealer.Hand.HandValue, bet, playerMoney);
					break;
				case ConsoleKey.D: // Draw
					deck.DrawCard (player.Hand);
					player.Hand.ShowHand ();
					//betting.checkForBust (player.Hand.HandValue, dealer.Hand.HandValue);
					betting.checkForWin (player.Hand.HandValue, dealer.Hand.HandValue, bet, playerMoney);
					break;
				case ConsoleKey.P:
					player.Hand.cards.Clear ();
					dealer.Hand.cards.Clear ();
					deck.Deal (player.Hand);
					deck.Deal (player.Hand);
					deck.Deal (dealer.Hand);
					player.Hand.ShowHand ();
					Console.WriteLine (player.Hand.HandValue);
					Console.WriteLine ((int)dealer.Hand.cards [0].Rank);
					betting.stand = false;
					break;
				default:
					break;
				}
			}
			//Console.ReadLine();
		}
	}
}
