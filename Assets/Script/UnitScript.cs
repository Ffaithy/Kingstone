using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * UnitScript
 * stores the cards into a collection
 * manages player's hand
 */
public class UnitScript : MonoBehaviour
{
    // Catch all numerical key presses
    private KeyCode[] keyCodes =
    {
         KeyCode.Alpha1,
         KeyCode.Alpha2,
         KeyCode.Alpha3,
         KeyCode.Alpha4,
         KeyCode.Alpha5,
         KeyCode.Alpha6,
         KeyCode.Alpha7,
         KeyCode.Alpha8,
         KeyCode.Alpha9,
        KeyCode.Alpha0,
    };


    private int _maxNumCards;
    public GameObject[] _deck;
    public GameObject[] _hand;

    // Use this for initialization
    void Start()
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
    void Update()
    {
        // Temporary controls to test out certain functions
        _tempControls();

    }

    // This function will be called at the start of each turn
    public void DrawCard()
    {


        // Search for the first empty slot in the hand, return index. 
        int availableHandSlot = System.Array.IndexOf(_hand, null);

        if ((availableHandSlot < 0) || (availableHandSlot >= _hand.Length))
        {
            return;
        }

        // Search for the first empty slot in the hand, return index. 
        int availableDeckSlot = System.Array.IndexOf(_deck, null);

        int maxRange = _deck.Length;
        if (availableDeckSlot > 0)
        {
            maxRange = availableDeckSlot;
        }

        int index = Random.Range(0, maxRange);

        Debug.Log("Generated index: " + index);
        // Set the returned index to the card at the top of the deck. 
        _hand[availableHandSlot] = _deck[index];

        Helpers.RemoveElementFromArray(_deck, index);

        // Remove the last elemement of the newly shifted array as it is now a duplicate of the element that came before it. 
        _deck[_deck.Length - (availableHandSlot + 1)] = null;
    }

    // This function will be called whenever a player plays a card
    public void PlayCard(int cardIndex)
    {
        // Do thing to place card on stage
       // if (_hand[cardIndex].GetComponent<CardScript>().EnergyCost > 5)
    

        Helpers.RemoveElementFromArray(_hand, cardIndex);

    }

    private void _tempControls()
    {
        if (Input.GetKeyDown("space"))
        {
            DrawCard();
        }

        for (int i = 0; i < keyCodes.Length; i++)
        {
            if (Input.GetKeyDown(keyCodes[i]))
            {
               // int numberPressed = i + 1;
                /*if (numberPressed == 10)
                {
                    numberPressed = 0;
                }*/
                PlayCard(i);
                Debug.Log(i);
            }
        }
   
    }
    //Homework Daras + update helpers script to cover adding game object to an array (line 89), include checks -  bonus: Think of helper functions for input
    //Homework Violeta + investigate turn logic, make button actually do something
    //Bonus - add plane representation of card 
}
