using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Card
{
    public string Name { get; set; }
    public bool IsFaceUp { get; set; }

    GameObject thisCard;

    public Card()
    {
    	Name = "";
    	IsFaceUp = false;
    	thisCard = GameObject.Find(Name);
    }

    public void Flip()
    {
    	thisCard.transform.Rotate(0.0f, 0.0f, 180.0f, Space.Self);
    }
}
