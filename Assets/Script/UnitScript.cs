using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * UnitScript
 * stores the cards into a collection
 * manages player's hand
 */
public class UnitScript : MonoBehaviour {

    private int _maxNumCards;
    public GameObject[] _deck;
    public GameObject[] _hand;

	// Use this for initialization
	void Start () 
    {
        GameConfig gameConfig = GameObject.Find("GameConfig").GetComponent<GameConfig>();
        this._maxNumCards = gameConfig.MaxNumCardsInDeck;
        _deck = new GameObject[_maxNumCards];
        _hand = new GameObject[gameConfig.MaxNumCardsInHand];


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

    public void DrawCard()
    {
        // pick card from deck
        // remove card from deck
        // place card in hand 
        // 
    }

    public void PlayCard(int cardIndex)
    {
        // pick card from hand
        // remove indexed card from hand
        // place card on stage TBD
    }

    //Homework Daras + Implement draw and remove card (google remove elements), make end turn button in unity scene
}
