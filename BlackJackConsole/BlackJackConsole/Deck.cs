using System;
using System.Linq;
using System.Collections.Generic;

namespace BlackJackConsole
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
//			Console.WriteLine (cards.SingleOrDefault);
//
////			cards.Sum
//			cards.ForEach (Console.WriteLine);
//			Console.WriteLine("BATMAN!!");
		
			var card = this.cards.FirstOrDefault();
			Console.WriteLine (card);
			Console.ReadLine ();
//
//			foreach (var tal in cards) {
//				Console.WriteLine (this.cards.);
//				Console.ReadLine ();
//			}
		}


		public void Shuffle()
		{
			this.cards.OrderBy(a => Guid.NewGuid()).ToList();
		}

		public void Deal(Hand hand)
		{
			var card = this.cards.FirstOrDefault();
			hand.AddCard (card);
		
			this.cards.Remove(card);

//			card = this.cards.First();
		}

		public void DrawCard(Hand hand)
		{

			var card = this.cards.FirstOrDefault();
			hand.AddCard(this.cards.First());

			this.cards.Remove(card);


		
		}



	}
}

