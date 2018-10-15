using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * DeckScript
 * stores the cards into a collection
 */
public class DeckScript : MonoBehaviour {

    private int _maxNumCards;
    private CardScript[] _deck;
	// Use this for initialization
	void Start () 
    {
        this._maxNumCards = GameObject.Find("GameConfig").GetComponent<GameConfig>().MaxNumCardsInDeck;
        _deck = new CardScript[_maxNumCards];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
