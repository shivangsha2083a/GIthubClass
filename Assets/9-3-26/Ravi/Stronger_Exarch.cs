using UnityEngine;

public class Stronger_Exarch : Enemy_Exarch
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
