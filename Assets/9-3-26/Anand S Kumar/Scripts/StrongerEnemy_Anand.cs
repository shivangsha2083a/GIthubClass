using UnityEngine;

public class StrongerEnemy_Anand : MonoBehaviour,IDamageable
{
    private int _damageCount,_blockCount;
    private bool _isDead;
    
    public void TakeDamage(int damage)
    {
        if (_isDead)return;
        if (_blockCount <= 5)
        {
            _blockCount++;
            Debug.Log("Block count: " + _blockCount);
            return;
        }
        else
        {
            _damageCount++;
            Debug.Log("Damage taken: " +damage);
            if(_damageCount==10)Die();
        }
    }
    public void Die()
    {
        _isDead = true;
        Debug.Log("Dead");
    }
}
