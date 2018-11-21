using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConfig : MonoBehaviour {

    public static GameObject[] Creatures;
    public static GameObject[] Attacks;

    public int MaxTurns;
    public int MaxNumCardsInDeck;

    private void Awake()
    {
        //Initialize the cards with the available prefabs
        Creatures = Resources.LoadAll<GameObject>("Creatures");
        Attacks = Resources.LoadAll<GameObject>("Attacks");

        Debug.Log("Creatures and Attacks initialized");
    }

    // Use this for initialization
    void Start () 
    {

	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    public GameObject GenerateCreature()
    {
        return Instantiate(Creatures[Random.Range(0, Creatures.Length)]);
    }

    public GameObject GenerateAttack()
    {
        return Instantiate(Attacks[Random.Range(0, Attacks.Length)]);
    }

}

// creature list
// attack list
//Creature and attack prefabs
// prefabs will take data from the above lists when instantiated 
// Homework: Daras: Come up with 15 attacks and 15 creatures, make prefabs
// Homework: Violetta: Come up with best practice for implementing attack and creature lists 
