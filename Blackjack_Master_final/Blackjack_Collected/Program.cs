using System;

namespace Blackjack_Collected
{
	class MainClass
	{
		static void Main() // Creating main game loop
		{
			// Making instance of the other classes
			Player player = new Player ();
			Dealer dealer = new Dealer ();
			Deck deck = new Deck();
			Hand hand = new Hand ();
			Betting betting = new Betting ();

			Console.WriteLine ("\n\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n");
			Console.WriteLine("Welcome to an experience of a lifetime!!!\nWelcome to a BlackJack game created by:\nKevin, Magnus & Nicklas");
			Console.WriteLine ("\n\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n");

			deck.SetDeck(); // Makes deck array
			deck.Shuffle(); // Randomizes deck array

			 /*
			deck.DisplayDeck(); // Show content of deck array
			*/
			 
			// Sets the starting money value of the game
			int playerMoney = 500;
			int bet = 0;

			bet = betting.calcBet(playerMoney, bet); // Runs the betting system
		    playerMoney -= bet;

			// Deals the cards to the player and dealer
			deck.Deal (player.Hand);
			deck.Deal (player.Hand);
			deck.Deal (dealer.Hand);

			Console.WriteLine ("\n\nThese were your draws:");
			player.Hand.ShowHand (); // Goes through the player hand array and displays it in the output window
			Console.WriteLine ("With a combined value of");
			Console.WriteLine (player.Hand.HandValue); // Add up the cards rank-value and displays it in the output window
			Console.WriteLine ("\n\nThe dealer draws:");
			dealer.Hand.ShowHand (); // Goes through the dealer hand array and displays it in the output window
			Console.WriteLine ("\nThe dealer has a combined value of");
			Console.WriteLine ((int)dealer.Hand.cards[0].Rank); // Only shows dealers first card
			Console.WriteLine ("Press 's' if you wish to stand and press 'd' if you wish to draw another card");

			while (true) {
				var key = Console.ReadKey (true);
				// Switch case that reads players keyboard input
				switch (key.Key) {
				case ConsoleKey.S: // Stand
					while (dealer.Hand.HandValue < 17 && dealer.Hand.HandValue < player.Hand.HandValue) // Simple dealer AI that hits as long as handvalue is below 17 and lowere than player handvalue
					{
						deck.DrawCard (dealer.Hand);
					}
					betting.stand = true;
					playerMoney = betting.checkForWin(player.Hand.HandValue, dealer.Hand.HandValue,  bet, playerMoney); // Checks if any winning or losing conditions is meet. 
					Console.WriteLine(playerMoney); // Updated bank total for player
					break;
				
				case ConsoleKey.D: // Draw
					deck.DrawCard (player.Hand); // Draws a new card from deck array and puts in the player hand
					player.Hand.ShowHand ();
					Console.WriteLine("\nYou: " + player.Hand.HandValue);
                    Console.WriteLine("Dealer: " + dealer.Hand.HandValue);
					if (player.Hand.HandValue > 21) // Checks if player is bust
				        {
						playerMoney = betting.checkForWin(player.Hand.HandValue, dealer.Hand.HandValue, bet, playerMoney); // Checks if any winning or losing conditions is meet.
                            Console.WriteLine(playerMoney);
                        }
				        else
				        {
                            Console.WriteLine("\n\nPress 's' if you wish to stand and press 'd' if you wish to draw another card\n");
				        }
				    break;
				case ConsoleKey.P: // Loops games and reset the deck
					deck.SetDeck();
					deck.Shuffle();
					//betting.calcBet (playerMoney, bet);
					bet = betting.calcBet(playerMoney, bet);
					playerMoney -= bet;
					player.Hand.cards.Clear ();
					dealer.Hand.cards.Clear ();
					deck.Deal (player.Hand);
					deck.Deal (player.Hand);
					deck.Deal (dealer.Hand);
					Console.WriteLine ("\n\nThese were your draws:");
					player.Hand.ShowHand ();
					Console.WriteLine ("With a combined value of");
					Console.WriteLine (player.Hand.HandValue);
					Console.WriteLine ("\n\nThe dealer draws:");
					dealer.Hand.ShowHand ();
					Console.WriteLine ("\nThe dealer has a combined value of");
					Console.WriteLine ((int)dealer.Hand.cards[0].Rank); // Only shows dealers first card
					Console.WriteLine ("Press 's' if you wish to stand and press 'd' if you wish to draw another card");
					betting.stand = false;
					break;
				default: // If no valid input it loops
					Console.WriteLine ("Not a valid input!");
					break;
				}
			}
		}
	}
}
