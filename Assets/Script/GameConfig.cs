using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum CardType { Attack, Creature }

[Serializable]
public class Card
{
    public string Name;
    public int ElixirCost;
}

[Serializable]
public class Creature
{
    public int Damage;

    public const CardType Type = CardType.Creature;
}

[Serializable]
public class Attack
{
    public int NumTurns;
    public int DamagePerTurn;

    public const CardType Type = CardType.Attack;
}

[Serializable]
public class CreatureCard
{
    public Card CardInfo;
    public Creature CreatureInfo;
}

[Serializable]
public class AttackCard
{
    public Card CardInfo;
    public Attack AttackInfo;
}

public class GameConfig : MonoBehaviour
{
    public int MaxTurns;
    public int MaxNumCardsInDeck;
   

    public CreatureCard[] Creatures;
    public AttackCard[] Attacks;


    // Use this for initialization
    void Start () 
    {	
	}
	
	// Update is called once per frame
	void Update ()
    {	
	}
}
