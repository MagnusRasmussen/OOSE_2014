﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace Blackjack_Collected
{
	public class Hand
	{

		private List<Card> cards = new List<Card>(5);

		public Hand ()
		{

		}
		public void AddCard(Card card)
		{
			this.cards.Add(card);


		}
	}
}
