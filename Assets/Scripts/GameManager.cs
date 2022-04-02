using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private GameState _gameState;

    private void Awake()
    {
        Instance = this;
    }


    public GameState GetGameState => _gameState;

    void Start()
    {
        _gameState = GameState.start;
    }

    // Update is called once per frame

    public void UpdateGameState(GameState gameState)
    {
        _gameState = gameState;
    }

    public void SwitchPlayer()
    {

        switch (_gameState)
        {
            case GameState.start:
                _gameState = GameState.player1A;
                break;
            case GameState.player1A:
                _gameState = GameState.player1B;
                break;
            case GameState.player1B:
                _gameState = GameState.player2A;
                break;
            case GameState.player2A:
                _gameState = GameState.player2B;
                break;
            case GameState.player2B:
                _gameState = GameState.player1A;
                break;
            case GameState.end:
                break;
        }
        Debug.Log(_gameState); //Alone
        //Console.Write("Hola Mundo Sobre Linea");
    }

    public void SwitchPlayerInverse()
    {

        switch (_gameState)
        {
            case GameState.player1B:
                _gameState = GameState.player1A;
                break;
            case GameState.player2B:
                _gameState = GameState.player2A;
                break;
        }
        Debug.Log(_gameState); //Alone
        //Console.Write("Hola Mundo Sobre Linea");
    }



    void Update()
    {
        switch (_gameState)
        {
            case GameState.start:
                break;
            case GameState.player1A:
                break;
            case GameState.player1B:
                break;
            case GameState.player2A:
                break;
            case GameState.player2B:
                break;
            case GameState.end:
                break;
        }
    }

    //Status
    public enum GameState
    {
        start,
        player1A,
        player1B,
        player2A,
        player2B,
        end
    }
}
