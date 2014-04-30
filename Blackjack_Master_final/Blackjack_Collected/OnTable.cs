using System;

namespace Blackjack_Collected
{
	public abstract class OnTable
	{
		public Hand Hand { get;  set; } // collects cards and relays it to player or dealer hand array
	}
}

