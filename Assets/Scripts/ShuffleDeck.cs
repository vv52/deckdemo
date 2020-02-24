using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuffleDeck : MonoBehaviour
{
	public GameManager gameManager;

    public void OnClick()
    {
    	gameManager.ShuffleDeck();
    }
}
