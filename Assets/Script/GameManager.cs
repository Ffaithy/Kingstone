using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager Instance { get; private set; }
    public PlayerScript Player;
    public PlayerScript Enemy;

    //static int MaxNumTurns;
    private const int _maxNumTurns = 10;
    private int _currentTurn = 0;

    private enum GameState { GameStart, PlayerTurn, EnemyTurn, GameEnd };

    private GameState _gameState = GameState.GameStart;

    //constant values in unity
    // convert to singleton for game manager

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
