using UnityEngine;

public class NPC_Anand : NPC_Anand_Parent
{
    private int _damageCount;
    private bool _isDead;
    
    public override void TakeDamage()
    {
        if (_isDead)return;
        Debug.Log("Invulnerable");
        _damageCount++;
        if (_damageCount == 5)
        {
            Die();
        }
    }

    public override void Die()
    {
        Debug.Log("Stupid");
        _isDead = true;
    }
}
