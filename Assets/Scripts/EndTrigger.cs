﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;
	void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
