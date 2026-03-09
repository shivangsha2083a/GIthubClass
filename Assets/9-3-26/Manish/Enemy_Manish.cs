using UnityEngine;

public class Enemy_Manish : MonoBehaviour, IDamageable
{
    private int damagecount;


    public void Die()
    {
        Debug.Log("Enemy Died");
    }

    public void TakeDamage(int damage)
    {
        damagecount++;
        if(damagecount >=  5)
        {
            Die();
        }
        Debug.Log("Take Damage");
    }


}
