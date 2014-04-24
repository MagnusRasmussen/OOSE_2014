using System;
using System.Linq;
using System.Collections.Generic;

namespace Blackjack_Collected
{
	public class Deck
	{
		public List<Card> cards = new List<Card>(52);

		public Deck ()
		{
			this.SetDeck ();
		
		}

		public void SetDeck()
		{
			this.cards.Clear ();
			this.cards.AddRange(Enumerable.Range(1,4).SelectMany(s => Enumerable.Range(1,13).Select(n => new Card((Rank)n, (Suite)s))));

		}


		public void Shuffle()
		{
			cards = cards.OrderBy(c => Guid.NewGuid()).ToList();     
		
		}

		public void Deal(Hand hand)
		{
			var card = this.cards.FirstOrDefault();
			hand.AddCard (card);
		
			this.cards.Remove(card);

		}

		public void DrawCard(Hand hand)
		{

			var card = this.cards.FirstOrDefault();
			hand.AddCard(this.cards.First());
            this.cards.Remove(card);
            		
		}

        public void DispalyDeck()
        {
            {
                int i;

                for (i = 0; i < cards.Count; i++)
                {

                    var card = cards[i];
                    Console.WriteLine(card.Suite + " " + card.Rank);

                }
                Console.ReadLine();
            }


        }



	}
}

