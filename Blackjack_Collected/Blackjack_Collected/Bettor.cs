using System;

namespace Blackjack_Collected
{
	public class Betting
	{
		public void calcBet(int playerMoney, int bet)
		{
			playerMoney = 500;

			Console.WriteLine ("Welcome, please place your bet. Your bank is {0}$\n", playerMoney);

			bool betValid = false;

			do{
				Console.WriteLine ("How much do you want to wager?");

				int input = Convert.ToInt32 (Console.ReadLine());


				if ((input <= playerMoney) & (input > 0))
				{
					bet = input;
					Console.Write ("You have chosen to bet {0}$ \n Is this the amount you want to bet? Y/N", bet);

					ConsoleKeyInfo info = Console.ReadKey();

					if (info.Key == ConsoleKey.Y){
						Console.ReadLine();
						Console.WriteLine ("\nProceeding with game..");

						betValid = true;

						playerMoney = playerMoney - bet;

						Console.Write ("playermoney = {0} \n", playerMoney);
						Console.Write ("bet = {0} \n", bet);

					}

					if (info.Key == ConsoleKey.N){
						Console.ReadLine();
					}
				}

			} while(!betValid); 

		}

		public void checkForWin(int playerValue, int dealerValue)
		{
			int winnings = 0;

			if ((playerValue == 21) & (dealerValue == 21))
			{
				Console.WriteLine ("You: " + playerValue);
				Console.WriteLine ("Dealer: " + dealerValue);
				Console.WriteLine ("Both You and the Dealer has a BlackJack!");
			}
			else if (playerValue == 21)
			{
				Console.WriteLine ("You: " + playerValue);
				Console.WriteLine ("Dealer: " + dealerValue);
				Console.WriteLine ("You have a BlackJack!");
			} 
			else if (dealerValue == 21) 
			{
				Console.WriteLine ("You: " + playerValue);
				Console.WriteLine ("Dealer: " + dealerValue);
				Console.WriteLine ("The Dealer has a BlackJack!");
			}
			else if (playerValue == dealerValue)
			{
				Console.WriteLine ("You: " + playerValue);
				Console.WriteLine ("Dealer: " + dealerValue);
				Console.WriteLine ("It's a tie!");
			}
			else if (playerValue < dealerValue)
			{
				Console.WriteLine ("You: " + playerValue);
				Console.WriteLine ("Dealer: " + dealerValue);
				Console.WriteLine ("The Dealer wins!");
			} 
			else if (playerValue > dealerValue)
			{
				Console.WriteLine ("You: " + playerValue);
				Console.WriteLine ("Dealer: " + dealerValue);
				Console.WriteLine ("You win!");
			}
		}

		public void checkForBust(int value, bool dealer)
		{
			if (value > 21 && dealer) {
				Console.WriteLine ("You win!, Dealer Bust");
			}
			else if (value > 21 && !dealer)
			{

				Console.WriteLine (value +" You Bust, The Dealer wins!");
			} 


		}


		//		public void checkForWin(int playerValue, int dealerValue)
//		{
//
//			if ((Player.Hand.HandValue == 21) & (Dealer.Hand.HandValue == 21))
//			{
//				Console.WriteLine ("Both You and the Dealer has a BlackJack!");
//			}
//			else if (Player.Hand.HandValue == 21)
//			{
//				Console.WriteLine ("You have a BlackJack!");
//			} 
//			else if (Dealer.Hand.HandValue == 21) 
//			{
//				Console.WriteLine ("The Dealer has a BlackJack!");
//			}
//			else if (Player.Hand.HandValue == Dealer.Hand.HandValue)
//			{
//				Console.WriteLine ("It's a tie!");
//			}
//			else if (Player.Hand.HandValue < Dealer.Hand.HandValue)
//			{
//				Console.WriteLine ("The Dealer wins!");
//			} 
//			else if (Player.Hand.HandValue > Dealer.Hand.HandValue)
//			{
//				Console.WriteLine ("You win!");
//			}
//		}
	}
}

