using UnityEngine;

public class Player : MonoBehaviour
{

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Game_Manager.Instance.startGame();
        Game_Manager.Instance.OnBossSpawned.AddListener(bossSpawned);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void bossSpawned()
    {
        print("Fuck you");
    }
}
