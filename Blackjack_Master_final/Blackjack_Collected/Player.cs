using System;
using System.Linq;
using System.Collections.Generic;

namespace Blackjack_Collected
{
	public class Player : OnTable
	{
		public Player ()
		{
			this.Hand = new Hand();
		}


		public class Money
		{
			public int playerMoney{ get; set;}
			public int bet { get; set;}
		}
	
	}
}

