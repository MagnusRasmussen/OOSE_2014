using System;

namespace Main
{
	public class Card
	{
		public Suite Suite { get; set;}
		public Rank Rank { get; set;}

		public Card (Rank rank, Suite suite)
		{
			this.Rank = rank;
			this.Suite = suite;
		}
	}
}

