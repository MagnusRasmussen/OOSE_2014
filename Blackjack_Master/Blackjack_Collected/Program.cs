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

//			Player.Money money = new Player.Money (); 
//			money.playerMoney = 500;
//			money.bet = 0;

			deck.SetDeck();
			deck.Shuffle();

			#region DisplayDeck
//			deck.DispalyDeck();
			#endregion

			int playerMoney = 500;
			int bet = 0;

			betting.calcBet (playerMoney, bet);



		

//			betting.calcBet (money.playerMoney, money.bet);

//			playerMoney = money.playerMoney;
//			bet = money.bet;

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
					int blabla = betting.checkForWin (player.Hand.HandValue, dealer.Hand.HandValue,  bet, playerMoney);

					//int blabla = betting.checkForWin (playerMoney);
					Console.WriteLine (blabla);
					break;
				case ConsoleKey.D: // Draw
					deck.DrawCard (player.Hand);
					player.Hand.ShowHand ();
					//betting.checkForBust (player.Hand.HandValue, dealer.Hand.HandValue);
					Console.WriteLine (bet);
					betting.checkForWin (player.Hand.HandValue, dealer.Hand.HandValue,  bet, playerMoney);
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
