using UnityEngine;

public class p1 : MonoBehaviour
{
    public string playerName;
    public int health = 100;

    public void Move()
    {
        Debug.Log(playerName + " is moving.");
    }

    public void Jump()
    {
        Debug.Log(playerName + " jumped.");
    }
}