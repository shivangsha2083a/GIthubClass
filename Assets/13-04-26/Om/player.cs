using System;
using UnityEngine;

public class Sing_Player : MonoBehaviour
{
    private void Awake()
    {
        Singelton_GameManager.Instance.StartGame();

        Singelton_GameManager.Instance.OnBossSpawned.AddListener(BossSpawned);

    }

    private void BossSpawned()
    {
        Debug.Log("BossSpawned");
    }
}
