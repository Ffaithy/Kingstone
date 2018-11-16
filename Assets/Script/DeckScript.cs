using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * DeckScript
 * stores the cards into a collection
 */
public class DeckScript : MonoBehaviour {

    private int _maxNumCards;

    GameObject[] _deck;

	// Use this for initialization
	void Start () 
    {
        this._maxNumCards = GameObject.Find("GameConfig").GetComponent<GameConfig>().MaxNumCardsInDeck;

        _deck = new GameObject[this._maxNumCards];

        for (int i = 0; i < this._maxNumCards; ++i)
        {
            _deck[i] = Instantiate(Resources.Load("Creature") as GameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
