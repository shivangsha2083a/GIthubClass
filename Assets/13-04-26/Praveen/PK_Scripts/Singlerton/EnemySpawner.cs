using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private void OnEnable()
    {
        GameManager.OnGameStart += SpawnEnemy;
    }
    
    void SpawnEnemy()
    {
        Debug.Log("Ready to fight boss");
    }
}