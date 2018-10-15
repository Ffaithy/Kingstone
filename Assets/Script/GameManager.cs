using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager Instance { get; private set; }
    public PlayerScript Player;
    public PlayerScript Enemy;

    //static int MaxNumTurns;
    private int _maxNumTurns;
    private int _currentTurn = 0;

    private enum GameState { GameStart, PlayerTurn, EnemyTurn, GameEnd };

    private GameState _gameState = GameState.GameStart;

    //constant values in unity
    // convert to singleton for game manager
<<<<<<< HEAD

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
		
=======
	// Use this for initialization
	void Start () 
    {
        this._maxNumTurns = GameObject.Find("GameConfig").GetComponent<GameConfig>().MaxTurns;  
>>>>>>> 36b8aae9c734f79281c06d2f8bb747c597c5fffa
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}
}
