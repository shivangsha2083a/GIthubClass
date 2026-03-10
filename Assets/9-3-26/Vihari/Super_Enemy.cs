using UnityEngine;

public class Super_Enemy : NPC_Vihari_Parent
{
    int count = 0;
    int Ehealth = 10;
    public override void Die()
    {
        Debug.Log(playerName + "says: How is this possible?");
    }

    public override void TakeDamage(int damage)
    {
        if (Ehealth > 5)
        {
            count++;
            Debug.Log(playerName + "says: Try harder");
        }
        else
        {
            Ehealth = Ehealth - damage;
        }
        if (Ehealth == 0)
        {
            Die();
        }
    }
}
