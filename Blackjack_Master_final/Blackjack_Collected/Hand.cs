using System;
using System.Linq;
using System.Collections.Generic;

namespace Blackjack_Collected
{
	public class Hand
	{
		//Here we create a new list of maximum 5 cards since that is the maximum number of cards allowed in blackjack
		public List<Card> cards = new List<Card>(5);

		// Adds up the hand values of the card rank in the given hand array
		public int HandValue
		{
			get{
				int handValue;
				var aces = this.cards.Count (c => c.Rank == Rank.Ace);
				var acesCount = this.cards.Count (c => c.Rank == Rank.Ace);

				handValue = cards.Select (c => (int)c.Rank > 1 && (int)c.Rank < 11 ? (int)c.Rank : 10).Sum (); // Changes value of all facecards and ace to 10
	
				while (acesCount > 0) { // Fixes high ace to 11
					handValue += 1;
					acesCount--;
				}

				while (handValue > 21 && aces > 0) { // If handvalue exceeds 21 and an aces in hand that aces value is changed to 1
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
				//Console.WriteLine("\n\ncheck");
				for (i = 0; i < cards.Count; i++) // Display each card in given hand array with suite and rank
				{

					var card = cards[i];

					Console.WriteLine(card.Rank + " of " + card.Suite);

				}
			}


		}


		public void AddCard(Card card) // Takes card from deck and add to given hand array
		{
			this.cards.Add(card);


		}

	}
}