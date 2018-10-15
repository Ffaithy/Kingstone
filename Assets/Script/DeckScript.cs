using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * DeckScript
 * stores the cards into a collection
 */
public class DeckScript : MonoBehaviour {

    private int _maxNumCards;

	// Use this for initialization
	void Start () 
    {
        this._maxNumCards = GameObject.Find("GameConfig").GetComponent<GameConfig>().MaxNumCardsInDeck;  	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
