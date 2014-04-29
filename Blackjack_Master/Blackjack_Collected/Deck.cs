using System;
using System.Linq;
using System.Collections.Generic;

namespace Blackjack_Collected
{
	public class Deck
	{
		//here we create a new list called cards that can contain the full deck
		public List<Card> cards = new List<Card>(52);

		public Deck ()
		{
			this.SetDeck ();
		
		}

		//this is used to fill the deck with the cards 
		public void SetDeck()
		{
			this.cards.Clear ();
			this.cards.AddRange(Enumerable.Range(1,4).SelectMany(s => Enumerable.Range(1,13).Select(n => new Card((Rank)n, (Suite)s))));

		}

		// here we randomise the cards in the list in order to mirror a real life shuffleing
		public void Shuffle()
		{
			cards = cards.OrderBy(c => Guid.NewGuid()).ToList(); 
			//Console.WriteLine("Shuffling");
		
		}
		//this is used to deal two cards and  then remove them from the deck afterwards
		public void Deal(Hand hand)
		{

			for (int deal = 0; deal < 2; deal++) {
				var card = this.cards.FirstOrDefault ();
				hand.AddCard (card);
				this.cards.Remove (card);

//				Console.WriteLine((int)deal);
			}
			Console.WriteLine("Dealing cards");


		}
		//this is used to draw one card and  then remove that card from the link afterwards
		public void DrawCard(Hand hand)
		{

			var card = this.cards.FirstOrDefault();
			hand.AddCard(this.cards.First());
            this.cards.Remove(card);

			Console.WriteLine ("Drawing a card");
            		
		}


		//we use this to check if the deck is actually creating the deck by outputting it to the console
        public void DispalyDeck()
        {
            {
                int i;

                for (i = 0; i < cards.Count; i++)
                {

                    var card = cards[i];
					Console.WriteLine(card.Suite + " " + (int)card.Rank);

                }
				Console.WriteLine ((int)cards.Count);
//                Console.ReadLine();
            }


        }



	}
}

