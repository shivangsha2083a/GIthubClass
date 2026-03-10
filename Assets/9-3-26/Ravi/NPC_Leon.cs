using UnityEngine;

public class NPC_Leon : NPC_Leon_Parent
{
    public void ApplyDamageToNPC(int damage)
    {
        TakeDamage(damage);
    }
    
    protected override void TakeDamage(int damage)
    {
        Debug.Log("Invulnerable aka Immortal");
        damageCounter++;
        if (damageCounter >= 5)
        {
            Debug.Log("Stupid");
        }
    }
}