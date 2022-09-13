// See https://aka.ms/new-console-template for more information

using CardGameApp;

var deck = new PokerDeck();
var cards = deck.DealCards();

foreach (var card in cards)
{
    Console.WriteLine(card);
}

Console.ReadLine();
