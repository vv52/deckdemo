using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipCard : MonoBehaviour
{
	public GameManager gameManager;

    public void OnClick()
    {
    	gameManager.FlipCard();
    }
}
