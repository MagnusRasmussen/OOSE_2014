using System;

namespace Blackjack_Collected
{
	public class Betting
	{
		public bool stand = false;
//		int returnBet = 0;
//		public int playerMoney = 500;
//		public int bet = 0;
//
//		Player.Money money = new Player.Money (); 
//		public Betting ()
//		{
//			money.playerMoney = 500;
//			money.bet = 0;
//		}

		public int calcBet(int playerMoney, int bet)
		{
			Console.WriteLine ("Welcome, please place your bet. Your bank is {0}$\n", playerMoney);

			bool betValid = false;

			do{
				Console.WriteLine ("How much do you want to wager?");

				// Converts written numbers in the console
				int input = Convert.ToInt32 (Console.ReadLine());

				// Checks if number written is highere than the money allow and that the value is a positive number
				if ((input <= playerMoney) & (input > 0))
				{
					bet = input;
					Console.Write ("You have chosen to bet {0}$ \n Is this the amount you want to bet? Y/N\n", bet);

					// Reads keyboard input
					ConsoleKeyInfo info = Console.ReadKey();

					if (info.Key == ConsoleKey.Y){
						Console.ReadLine();
						Console.WriteLine ("\nProceeding with game..");

						betValid = true;

						playerMoney -= bet;

						Console.Write ("playermoney = {0} \n", playerMoney);
						Console.Write ("bet = {0} \n", bet);

					}

					if (info.Key == ConsoleKey.N){
						Console.ReadLine();
					}


				}

			} while(!betValid);
			//returns bet to program class
		    return bet;
        }

		public int checkForWin(int playerValue, int dealerValue, int bet, int newBalance)
		{
			//int winnings = 0;
		
			Console.WriteLine ("You: " + playerValue);
			Console.WriteLine ("Dealer: " + dealerValue);

			// The rules for this black game. It check if either player or dealer is bust and then who has won.
		    if (playerValue < 22 && dealerValue > 21)
		    {
		        Console.WriteLine("You win!, Dealer Bust");
				Console.WriteLine (newBalance);
				Console.WriteLine (bet);
				newBalance = newBalance + bet * 2;
		    }
		    else if (playerValue > 21 && dealerValue < 22)
		    {
		        Console.WriteLine("You Bust, The Dealer wins!");
		        //newBalance = newBalance;
		    }
		    else if ((playerValue == 21) & (dealerValue == 21))
		    {
		        Console.WriteLine("Both You and the Dealer has a BlackJack!");
		        newBalance = newBalance + bet;
		    }
		    else if (playerValue == 21)
		    {
		        Console.WriteLine("You have a BlackJack!");
		        newBalance = newBalance + bet * 2;
		    }
		    else if (dealerValue == 21)
		    {
		        Console.WriteLine("The Dealer has a BlackJack!");
		        //newBalance = newBalance;
		    }
		    else if (playerValue == dealerValue)
		    {
		        Console.WriteLine("It's a tie!");
		        newBalance = newBalance + bet;
		    }
		    else if (playerValue < dealerValue)
		    {
		        Console.WriteLine("The Dealer wins!");
		        //newBalance = newBalance;
		    }
		    else if (playerValue > dealerValue)
		    {
		        Console.WriteLine("You win!");
		        newBalance = newBalance + bet * 2;
		    }

	
			Console.WriteLine("\n\nIf you wish to play another game press 'p' \n");
			Console.WriteLine("Your bank total is currently at:");

			// Returns new value
			return newBalance;

		}

	}
}

