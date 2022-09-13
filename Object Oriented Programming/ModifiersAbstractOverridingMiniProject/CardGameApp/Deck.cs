// See https://aka.ms/new-console-template for more information
using CardGameApp;

public abstract class Deck
{
    protected List<PlayingCardModel> fullDeck = new();
    protected List<PlayingCardModel> drawPile = new();
    protected List<PlayingCardModel> discardPile = new();

    protected void CreateDeck()
    {
        fullDeck.Clear();

        for (int suit = 0; suit < 4; ++suit)
        {
            for (int val = 0; val < 13; ++val)
            {
                fullDeck.Add(new PlayingCardModel
                {
                    Suit = (CardSuit)suit,
                    Value = (CardValue)val
                });
            }
        }
    }

    public virtual void ShuffleDeck()
    {
        var rnd = new Random();
        drawPile = fullDeck.OrderBy(x => rnd.Next()).ToList();
    }

    public abstract List<PlayingCardModel> DealCards();
    
    protected virtual PlayingCardModel RequestCard()
    {
        var output = drawPile.Take(1).First();
        drawPile.Remove(output);
        return output;
    }
}