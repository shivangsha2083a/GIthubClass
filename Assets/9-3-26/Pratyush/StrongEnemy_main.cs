
using UnityEngine;

public class StrongEnemy_main : MonoBehaviour, IDamageable
{
    private int totalHitCount;
    private int damageCount;
    private bool isDead;

    public void Die()
    {
        if (isDead) return;
        isDead = true;
        Debug.Log("Strong Enemy has died.");
    }

    void Start()
    {
        StartDamage();
    }

   
    public void TakeDamage(int damage)
    {
        if (isDead) return;

       
        totalHitCount++;

        
        if (totalHitCount <= 5)
        {
            Debug.Log($"Hit {totalHitCount}: Blocked.");
            return;
        }

        
        damageCount += damage;
        Debug.Log($"Hit {totalHitCount}: Took {damage} damage (accumulated damage: {damageCount}).");

       
        if (totalHitCount >= 10)
        {
            Die();
        }
    }

    
    public void StartDamage()
    {
        Debug.Log("Strong Enemy: simulating 10 hits (first 5 blocked, die on 10th).");
        for (int i = 0; i < 10; i++)
        {
            TakeDamage(1);
        }
    }
}