using System;

namespace Blackjack_Collected
{
	//here we combine the ranks and the suites to make create a class that contains both properties
	public class Card
	{
		public Suite Suite { get; set;}
		public Rank Rank { get; set;}

		//This is where we make a construct to contain the card information
		public Card (Rank rank, Suite suite)
		{
			this.Rank = rank;
			this.Suite = suite;
		}
	}
}

