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


				int input = Convert.ToInt32 (Console.ReadLine());


				if ((input <= playerMoney) & (input > 0))
				{
					bet = input;
					Console.Write ("You have chosen to bet {0}$ \n Is this the amount you want to bet? Y/N\n", bet);

					ConsoleKeyInfo info = Console.ReadKey();

					if (info.Key == ConsoleKey.Y){
						Console.ReadLine();
						Console.WriteLine ("\nProceeding with game..");

						betValid = true;

						playerMoney -= bet;

//						money.playerMoney = playerMoney;
//						money.bet = bet;



						Console.Write ("playermoney = {0} \n", playerMoney);
						Console.Write ("bet = {0} \n", bet);



					}

					if (info.Key == ConsoleKey.N){
						Console.ReadLine();
					}


				}

			} while(!betValid);

		    return bet;
        }

		public int checkForWin(int playerValue, int dealerValue, int bet, int newBalance)
		{
			//int winnings = 0;
		
			Console.WriteLine ("You: " + playerValue);
			Console.WriteLine ("Dealer: " + dealerValue);

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

		    //money.playerMoney = newBalance;
			Console.WriteLine("\n\nIf you wish to play another game press 'p' \n");
			//Console.WriteLine ("Your bank is now at {0} ", newBalance);
			Console.WriteLine("Your bank total is currently at:");
			return newBalance;
			//newBalance = playerMoney + winnings;
			//return playerMoney;
		}

//		public void checkForBust(int playerValue, int dealerValue)
//		{
//			Console.WriteLine ("You: " + playerValue);
//			Console.WriteLine ("Dealer: " + dealerValue);
//
//			if (playerValue < 22 && dealerValue > 21)
//			{
//				Console.WriteLine ("You win!, Dealer Bust");
//				winnings = playerMoney + bet*2;
//			}
//			else if (playerValue > 21 && dealerValue < 22)
//			{
//				Console.WriteLine ("You Bust, The Dealer wins!");
//			} 
//			else if (stand)
//			{ checkForWin (playerValue, dealerValue);
//			}
//
//		}
	}
}

