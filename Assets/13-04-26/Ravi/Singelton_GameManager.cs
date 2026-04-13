using System;
using UnityEngine;
using UnityEngine.Events;

public class Singelton_GameManager : MonoBehaviour
{
    public static Singelton_GameManager Instance;

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
