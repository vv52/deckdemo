using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCard2 : MonoBehaviour
{
	public GameManager gameManager;

    public void OnClick()
    {
    	gameManager.DrawBottomCard();
    }
}
