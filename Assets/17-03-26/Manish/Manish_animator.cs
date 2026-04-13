using UnityEngine;

public class Manish_animator : MonoBehaviour
{

    public Animator animator;
   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("death");
        }

        if(Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("damage");
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("idle");
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("move");
        }
    }
}
