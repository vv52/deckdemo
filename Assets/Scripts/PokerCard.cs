using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokerCard : Card
{
	
    public string Suit { get; set; }
    public int Value { get; set; }

    public PokerCard()
    {
    	Suit = "";
    	Value = -1;
    }
}