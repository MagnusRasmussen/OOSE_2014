using System;

namespace Blackjack_Collected
{
	public class Dealer : OnTable
	{
		public Dealer ()
		{
			this.Hand = new Hand();
		}


//draft for the dealerAI code
//		public void DealerAI (int dHandValue, int bHandValue)
//		{
//			bool dealerTurnOver = false;
//
//			if (dHandValue > 21)
//			{
//				Console.WriteLine ("The Dealer is bust!");
//				dealerTurnOver = true;
//			}
//			do 
//			{
//				if ( dHandValue < 17)
//				{
//					Console.WriteLine ("The Dealer hits");
//					deck.Deal(dealer.Hand);
//					dealer.Hand.HandValue;
//					Console.ReadLine();
//				}
//				else
//				{
//					Console.WriteLine ("The Dealer stands");
//					dealer.Hand.HandValue;
//					dealerTurnOver = true;
//				}
//			}
//		}


	}
}

