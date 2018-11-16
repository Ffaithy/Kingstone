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

    //Homework Daras + Violeta - figure how to use the resource script to randomly pick 30 cards from the list of prefabs *extra credit figure out how to make hand system
    //Homework Daras - Make 30 more cards
    //Homework Violeta - investigate merging component system and property drawer without breaking prefabs 
}
