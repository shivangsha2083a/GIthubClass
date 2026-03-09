using UnityEngine;

public class Enemy_Exarch : MonoBehaviour, IDamageable
{
    protected int damageCounter;
    public void TakeDamage(int damage)
    {
        Debug.Log($"Enemy took {damage} damage");
        damageCounter++;
        if (damageCounter >= 5)
        {
            Die();
        }
    }

    public void Die()
    {
        Debug.Log("Enemy Died");
    }
}
