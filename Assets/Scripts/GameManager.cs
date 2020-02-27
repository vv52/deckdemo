using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject CardPrefab;

    private PokerDeck _deck;

    void Start()
    {
    	_deck = new PokerDeck();
    	_deck.Shuffle();
    }

    public void DrawTopCard()
    {
    	if (CardPrefab != null)
    	{
    		var card = GameObject.Instantiate<GameObject>(CardPrefab, Vector3.zero, Quaternion.identity);
    		var controller = card.GetComponent<CardManager>();

    		controller.Card = _deck.DrawFromTop();

    		if (controller != null)
    		{
    			controller.FaceMaterial = PokerCardFactory.GetInstance().Materials[controller.Card.Name];
    			controller.UpdateFaceMaterial();
    		}
    	}
    }

    public void DrawBottomCard()
    {
    	if (CardPrefab != null)
    	{
    		var card = GameObject.Instantiate<GameObject>(CardPrefab, Vector3.zero, Quaternion.identity);
    		var controller = card.GetComponent<CardManager>();

    		controller.Card = _deck.DrawFromBottom();

    		if (controller != null)
    		{
    			controller.FaceMaterial = PokerCardFactory.GetInstance().Materials[controller.Card.Name];
    			controller.UpdateFaceMaterial();
    		}
    	}
    }

    public void ShuffleDeck()
    {
    	_deck.Shuffle();
    }

    public void AddDeck()
    {
        _deck.AddDeck();
    }
}
