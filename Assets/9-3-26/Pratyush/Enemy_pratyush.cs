using UnityEngine;
using UnityEngine.Events;

public class Enemy_pratyush : MonoBehaviour, IDamageable
{

    
    private int Damagecount;

    public void Die()
    {
        Debug.Log("Enemy has died.");
    }

    public void TakeDamage(int damage)
    {
        Damagecount++;
        if (Damagecount >= 5)
        {
            Die();
        }
    }

    


}
