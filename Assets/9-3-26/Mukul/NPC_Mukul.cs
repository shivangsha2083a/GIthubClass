using UnityEngine;

public class NPC_Mukul : NPC_Mukul_Parent
{
    int count = 0;
    public override void TakeDamage()
    {
        count ++;
        if(count <= 5)
        {
            print("Stupid");
        }

        else
        {
            print("it hurts but i am immortal");
        }
    }
}
