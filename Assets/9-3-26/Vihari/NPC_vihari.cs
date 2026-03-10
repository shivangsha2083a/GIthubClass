using UnityEngine;

public class NPC_vihari : NPC_Vihari_Parent
{
    int count = 0;
    public override void Die()
    {
        Debug.Log(playerName + "says: idiot, im unkillable");
    }

    public override void TakeDamage(int damage)
    {
        if (health > 0)
        {
            count++;
            Debug.Log(playerName + "says: is that all you got?");

            if(count / 5 ==1)
            {
                Debug.Log(playerName + "says: stupid");
            }
        }
    }
}
