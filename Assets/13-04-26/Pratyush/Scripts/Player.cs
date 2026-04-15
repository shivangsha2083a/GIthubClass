using UnityEngine;

public class Player : MonoBehaviour
{
    private void Start()
    {
        GameManager.Instance.StartGame();

        GameManager.Instance.EnemySpawned += OnEnemySpawned;
    }

    private void OnEnemySpawned()
    {
        Debug.Log("Player detected enemy spawn!");
    }

    private void OnDestroy()
    {
        if (GameManager.Instance != null)
            GameManager.Instance.EnemySpawned -= OnEnemySpawned;
    }
}