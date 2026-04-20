using System;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public static Action OnGameStart;   

    private void Awake()
    {
        Instance = this;
    }

    public void StartGame()
    {
        Debug.Log("Game Started");

        OnGameStart?.Invoke();  
    }
}