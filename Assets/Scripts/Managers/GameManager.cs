using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public GridManager GridManager;
    public PoolingManager PoolingManager;

    public event Action OnStartGame;
    public event Action OnGameOver;

    public void Awake()
    {
        //Application Settings
        Application.targetFrameRate = 60;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        //Manager Initialization
        PoolingManager.Initialize(this);
        GridManager.Initialize(this);
    }

    public void StartGame()
    {
        if(OnStartGame != null)
        {
            OnStartGame();
        }
    }

    public void GameOver()
    {
        if(OnGameOver != null)
        {
            OnGameOver();
        }
    }
}
