using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameApp
{
    public class PokerDeck : Deck
    {
        public PokerDeck()
        {
            CreateDeck();
            ShuffleDeck();
        }
        public override List<PlayingCardModel> DealCards()
        {
            var cards = new List<PlayingCardModel>();
            for (int i = 0; i < 5; i++)
            {
                cards.Add(RequestCard());
            }

            return cards;
        }

        public List<PlayingCardModel> RequestCards(List<PlayingCardModel> cardsToDiscard)
        {
            var output = new List<PlayingCardModel>();

            foreach (var card in cardsToDiscard)
            {
                output.Add(RequestCard());
                discardPile.Remove(card);
            }

            return output;
        }
    }
}
