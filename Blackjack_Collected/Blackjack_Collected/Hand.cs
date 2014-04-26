using System;
using System.Linq;
using System.Collections.Generic;

namespace Blackjack_Collected
{
	public class Hand
	{
		//Here we create a new list of maximum 5 cards since that is the maximum number of cards allowed in blackjack
		private List<Card> cards = new List<Card>(5);


		//this class is meant to contain the cards in the hand
		public Hand ()
		{

		}

		//this is meant to calculate 
		public int HandValue()
		{

			int i;
			int handValue;
			for (i = 0; i < cards.Count; i++) {

				var card = cards [i];
				//this is where we determine whether or not the ace will be a highace or a lowace
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