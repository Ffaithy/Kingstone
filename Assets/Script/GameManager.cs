using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton {


    public PlayerScript Player;
    public PlayerScript Enemy;

    private int _maxNumTurns;
    private int _currentTurn = 0;

    private enum GameState { GameStart, PlayerTurn, EnemyTurn, GameEnd };

    private GameState _gameState = GameState.GameStart;

    //constant values in unity

  

	// Use this for initialization
	void Start () 
    {
        this._maxNumTurns = GameObject.Find("GameConfig").GetComponent<GameConfig>().MaxTurns;  
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}
}
