using UnityEngine;

public class Enemy_Anand : MonoBehaviour,IDamageable
{
    private int _damageCount;
    private bool _isDead;
    
    public void TakeDamage(int damage)
    {
        if (_isDead)return;
        Debug.Log("Damage taken: " + damage);
        _damageCount++;
        if (_damageCount == 5)Die();
    }

    public void Die()
    {
        Debug.Log("Enemy dead");
        _isDead = true;
    }
}
