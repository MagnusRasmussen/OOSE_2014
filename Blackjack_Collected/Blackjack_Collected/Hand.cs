using System;
using System.Linq;
using System.Collections.Generic;

namespace Blackjack_Collected
{
	public class Hand
	{
		//Here we create a new list of maximum 5 cards since that is the maximum number of cards allowed in blackjack
		public List<Card> cards = new List<Card>(5);


		//this class is meant to contain the cards in the hand
		public Hand ()
		{

		}

		//this is meant to calculate 
		public int HandValue
		{
			get{
//			int i;
				int handValue;
//			// for-loop goes though the each card in
//			for (i = 0; i < cards.Count; i++) {
//
//				var card = cards [i];
//				//this is where we determine whether or not the ace will be a highace or a lowace
//				if (card.Rank == 0 && (handValue + 11) < 22) { // should be rewritten to under 
//					handValue = 11;
//				} 
//				else {
//					handValue = 1;
//				}
//
//				if (card.Rank > 9) {
//					handValue = 10;
//				} 
//				else {
//					handValue = (int)card.Rank + 1;
//				}
//				handValue += HandValue;
//
//			}
//
//			if (cards.Count < 5) {
//
//			} 
//			else {
//				//PLAYER WON!!
//			}
////


				// Other solution

				var aces = this.cards.Count (c => c.Rank == Rank.Ace);
				var acesCount = this.cards.Count (c => c.Rank == Rank.Ace);

				handValue = cards.Select (c => (int)c.Rank > 1 && (int)c.Rank < 11 ? (int)c.Rank : 10).Sum ();
				//handValue = cards.Select (c => (int)c.Rank > 1 && (int)c.Rank < 11 ? (int)c.Rank : 10).Sum ();
				//handValue = cards.Select (c => (int)c.Rank = 1 ? 11 : 0).;

				while (acesCount > 0) {
					handValue += 1;
					acesCount--;
				}

				while (handValue > 21 && aces > 0) {
				handValue -= 10;
				aces--; 
			}
				return handValue;
			}
		}

		public void ShowHand()
		{
			{
				int i;
				Console.WriteLine("IN HAND ");
				for (i = 0; i < cards.Count; i++)
				{

					var card = cards[i];

					Console.WriteLine(card.Suite + " " + card.Rank);

				}
				//Console.WriteLine(HandValue);
			}


		}


		public void AddCard(Card card)
		{
			this.cards.Add(card);


		}

	}
}