using System;

namespace Betting_bitches
{
	class MainClass
	{
		public static void Main (string[] args)
		{


			int playerMoney = 500;

			string introduction = ("Welcome, please place your bet. Your bank is ");
			Console.Write (introduction);
			Console.Write (playerMoney);
			Console.Write ("$\n");

			bool betValid = false;

			do{
				Console.WriteLine ("How much do you want to wager?");

				int input = Convert.ToInt32 (Console.ReadLine());


				if ((input <= playerMoney) & (input > 0))
				{
					int bet = input;
					Console.Write ("You have chosen to bet ");
					Console.Write (bet);
					Console.Write ("$ \n" );
					Console.WriteLine ("Is this the amount you want to bet?  Y/N");

					ConsoleKeyInfo info = Console.ReadKey();

					if (info.Key == ConsoleKey.Y){
						Console.ReadLine();
						Console.WriteLine ("\nProceeding with game..");

						betValid = true;

						playerMoney = playerMoney - bet;

						Console.Write ("playermoney = "); Console.Write (playerMoney);
						Console.WriteLine();
						Console.Write ("bet = "); Console.Write (bet);

						Console.ReadLine();
					}

					if (info.Key == ConsoleKey.N){
						//Console.ReadLine();
						//Console.WriteLine ("\nOkay, please re-enter your bet");
						//betValid = false;
						Console.ReadLine();
					}
				}

				/*else
				{
					Console.WriteLine("Sorry, you don't have that much money to bet");
					betValid = false;
				}*/
			} while(!betValid); 
	
		}
	}
}
