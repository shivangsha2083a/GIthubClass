using UnityEngine;

public class StrongerEnemy_Praveen : Enemy_Praveen
{
    
    public new void TakeDamage(int damage)
    {
        damageCounter++;
        if (damageCounter <= 5)
        {
            Debug.Log("Blocked Hit ");
        }
        else if (damageCounter >= 10)
        {
            Die();
        }
        else if (damageCounter > 5)
        {
            Debug.Log("Took Damage Hit ");
        }
    }
}