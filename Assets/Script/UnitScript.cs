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

        // Set the returned index to the card at the top of the deck. 
        _hand[availableHandSlot] = _deck[0];

        // Array.pop, but for some reason unity doesn't offer this function in C#... for shame. 
        // Essentially, shift all element arrays up by one
        for (int i = 0; i < (_deck.Length - (availableHandSlot + 1)); i++)
        {
            _deck[i] = _deck[i + 1];
        }

        // Remove the last elemement of the newly shifted array as it is now a duplicate of the element that came before it. 
        _deck[_deck.Length - (availableHandSlot + 1)] = null;
    }

    // This function will be called whenever a player plays a card
    public void PlayCard(int cardIndex)
    {
        // Do thing to place card on stage

        _hand[cardIndex] = null; // remove card from hand

        for (int i = cardIndex; i < (_hand.Length - 1); i++)
        {
            _hand[i] = _hand[i + 1]; // pop array
        }
        _hand[_hand.Length -1] = null; // remove last element from array since we're left with a duplicate

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
                int numberPressed = i + 1;
                if (numberPressed == 10)
                {
                    numberPressed = 0;
                }
                PlayCard(numberPressed);
                Debug.Log(numberPressed);
            }
        }
   
    }
    //Homework Daras + Implement draw and remove card (google remove elements), make end turn button in unity scene
}
