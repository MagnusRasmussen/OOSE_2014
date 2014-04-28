using System;

namespace Betting_bitches
{
	public class Betting
	{
		public static void Bettor (string[] args)
		{
			int playerMoney = 500;

			Console.WriteLine ("Welcome, please place your bet. Your bank is {0}$\n", playerMoney);

			bool betValid = false;

			do{
				Console.WriteLine ("How much do you want to wager?");

				int input = Convert.ToInt32 (Console.ReadLine());


				if ((input <= playerMoney) & (input > 0))
				{
					int bet = input;
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
	}
}

