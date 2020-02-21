using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using UnityEngine;

public class Deck
{
    protected LinkedList<Card> Cards { get; set; }

    public Deck()
    {
    	Cards = new LinkedList<Card>();
    }

    public Card DrawFromTop()
    {
    	Card topCard = Cards.Last();
    	Cards.RemoveLast();
    	return topCard;
    }
    
    public Card DrawFromBottom()
    {
    	Card bottomCard = Cards.First();
    	Cards.RemoveFirst();
    	return bottomCard;
    }

    public void AddToTop(Card card)
    {
    	Cards.AddLast(card);
    }

    public void AddToBottom(Card card)
    {
    	Cards.AddFirst(card);
    }

    public void Shuffle()
    {
    	List<Card> tempDeck = Cards.ToList();
    	int cardCount = tempDeck.Count();
    	System.Random rng = new System.Random();

    	while (cardCount > 1)
    	{
    		cardCount--;
    		int tempIndex = rng.Next(cardCount + 1);
    		Card temp = tempDeck[tempIndex];
    		tempDeck[tempIndex] = tempDeck[cardCount];
    		tempDeck[cardCount] = temp;
    	}

    	Cards = new LinkedList<Card>(tempDeck);
    }

    public void Merge(Deck other)
    {
    	
    }
}
