using UnityEngine;

public class Super_Enemy : NPC_Vihari_Parent
{
    int count = 0;
    int health = 10;
    public override void Die()
    {
        Debug.Log(playerName + "says: How is this possible?");
    }

    public override void TakeDamage(int damage)
    {
        if (health > 5)
        {
            count++;
            Debug.Log(playerName + "says: Try harder");
        }
        else
        {
            health = health - damage;
        }
        if (health == 0)
        {
            Die();
        }
    }
}
