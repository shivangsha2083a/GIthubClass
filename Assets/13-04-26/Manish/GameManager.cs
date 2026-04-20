using UnityEngine;

public class GameManger : MonoBehaviour
{
    public static GameManger Instance;

    void Awake()
    {
        Instance = this;
    }


    public void  StartGame()
    {
        Debug.Log("Game is Started");
    }
}
