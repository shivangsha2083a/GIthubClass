using System;
using UnityEngine;
using UnityEngine.Events;

public class GameM : MonoBehaviour
{
    public static GameM Instance;

    public UnityEvent OnBossSpawned;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        OnBossSpawned?.Invoke();
    }

    public void StartGame()
    {
        Debug.Log("Game started");

    }
}
