﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCard : MonoBehaviour
{
	public GameManager gameManager;

    public void OnClick()
    {
    	gameManager.DrawTopCard();
    }
}
