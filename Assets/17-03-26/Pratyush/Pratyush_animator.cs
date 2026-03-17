using UnityEngine;

public class Pratyush_animator : MonoBehaviour
{
    public Animator anim;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("Idle");  
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("Death");
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("Move");
        }
        if(Input.GetKeyDown(KeyCode.F))
        {
            anim.SetTrigger("Damage");
        }
    }
}
