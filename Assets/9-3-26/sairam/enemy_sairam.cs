using UnityEngine;

public class enemy_sairam : MonoBehaviour
{
    private int damagecount;


    public void Die()
    {
        Debug.Log("Enemy Died");
    }

    public void TakeDamage(int damage)
    {
        damagecount++;
        if (damagecount >= 5)
        {
            Die();
        }
        Debug.Log("Take Damage");
    }


}
