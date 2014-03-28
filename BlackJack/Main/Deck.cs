using System;
using System.Linq;
using System.Collections.Generic;

namespace Main
{
	public class Deck
	{
		private List<Card> cards = new List<Card>(52);

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
			this.cards.OrderBy(a => Guid.NewGuid());
		}

		public void DrawCard()
		{

		}

		public void Deal()
		{

		}

	}
}

