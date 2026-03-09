using UnityEngine;

public class Player : MonoBehaviour
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

    protected virtual void TakeDamage(int damage)
    {
        
    }

    protected virtual void Die()
    {
        
    }
}