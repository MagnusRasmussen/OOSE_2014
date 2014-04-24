using System;
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

		public int HandValue()
		{

			int i;
			int handValue;
			for (i = 0; i < cards.Count; i++) {

				var card = cards [i];
				if (card.Rank == 0 && (handValue + 11) < 22) {
					handValue = 11;
				} 
				else {
					handValue = 1;
				}

				if (card.Rank > 9) {
					handValue = 10;
				} 
				else {
					handValue = (int)card.Rank + 1;
				}
				handValue += HandValue;

			}

			if (cards.Count < 5) {

			} 
			else {
				//PLAYER WON!!
			}


		}




		public void AddCard(Card card)
		{
			this.cards.Add(card);


		}

	}
}