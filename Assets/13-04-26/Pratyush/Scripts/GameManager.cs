using System;
using Unity.Plastic.Newtonsoft.Json.Converters;
using UnityEditor.Profiling.Memory.Experimental;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public event Action EnemySpawned;

    private void Awake()
    {
        Instance = this;
    }

    public void StartGame()
    {
        Debug.Log("Game Started");

        SpawnEnemy();
    }

    public void SpawnEnemy()
    {
        Debug.Log("Enemy Spawned");

        EnemySpawned?.Invoke();
    }
}

