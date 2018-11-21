using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * DeckScript
 * stores the cards into a collection
 */
public class DeckScript : MonoBehaviour {

    private int _maxNumCards;
    public GameObject[] _deck;

	// Use this for initialization
	void Start () 
    {
        GameConfig gameConfig = GameObject.Find("GameConfig").GetComponent<GameConfig>();
        this._maxNumCards = gameConfig.MaxNumCardsInDeck;
        _deck = new GameObject[_maxNumCards];

        //Populate deck by choosing random cards
        for (int i = 0; i < _maxNumCards; i++)
        {
            int type = Random.Range(0, 2);
            if (type == 0)
            {
                _deck[i] = gameConfig.GenerateCreature();
            }
            else
            {
                _deck[i] = gameConfig.GenerateAttack();
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Homework Daras + Violeta - figure how to use the resource script to randomly pick 30 cards from the list of prefabs *extra credit figure out how to make hand system
    //Homework Daras - Make 30 more cards
    //Homework Violeta - investigate merging component system and property drawer without breaking prefabs 
}
