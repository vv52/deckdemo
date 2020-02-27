using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddDeck : MonoBehaviour
{
	public GameManager gameManager;

    public void OnClick()
    {
    	gameManager.AddDeck();
    }
}
