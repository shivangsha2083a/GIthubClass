using UnityEngine;
using UnityEngine.Events;

public class Game_Manager : MonoBehaviour
{
    public static Game_Manager Instance;
    public UnityEvent OnBossSpawned;
    public void Awake()
    {
        Instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        print("Game is Start");
    }

    
}
