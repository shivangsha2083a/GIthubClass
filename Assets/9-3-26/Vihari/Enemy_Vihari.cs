using UnityEngine;

public class Enemy_Vihari : MonoBehaviour , IDamageable 
{
    public string enemy_name;
    public int health = 50;
    public virtual void TakeDamage(int damage)
    {
        if(health>0)
        {
            health = health - damage;
            Debug.Log(enemy_name + " has taken " + damage + " damage, current health: " + health);
        }
        
    }

    public virtual void Die()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            Debug.Log(enemy_name + "has died");
        }
    }
}
