using UnityEngine;

public class GameManager : MonoBehaviour

{
    public static GameManager Instance;

    void Awake()
    {
        Instance =  this;
    }

    public void StartGame()
    {
        Debug.Log("Game started");
    }
    
}
