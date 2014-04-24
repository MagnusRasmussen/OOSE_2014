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
		
            //var card = this.cards.FirstOrDefault();
            //Console.WriteLine(card.Rank + " " + card.Suite);
            //Console.ReadLine ();
            
            //foreach (var tal in cards) {
            //    Console.WriteLine(cards.card.Rank + " " + card.Suite);
            //    Console.ReadLine ();
            //}

            //int i;
            //for (i = 0; i < 52; i++)
            //{
            //    //for (j = 1; j < 2; j++)
            //    //{
            //    var card = cards[i];
            //    Console.WriteLine(card.Suite + " " + card.Rank);
            //    //Console.ReadLine();
            //    //}
            //    //Console.WriteLine();
            //}
            //Console.ReadLine();
            Shuffle();
		}


		public void Shuffle()
		{
			this.cards.OrderBy(a => Guid.NewGuid()).ToList();

            //var card = this.cards.FirstOrDefault();
            //Console.WriteLine(card.Rank + "" + card.Rank);
            //Console.ReadLine();
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

        public void DispalyDeck(){
            		{
            int i;
           
           for (i = 0; i < 52; i++)
            {
           
                    var card = cards[i];
                    Console.WriteLine(card.Suite + " " + card.Rank);
         
            }
            Console.ReadLine();
			}
        

        }



	}
}

