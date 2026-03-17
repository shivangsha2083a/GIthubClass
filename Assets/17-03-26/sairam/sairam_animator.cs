using UnityEngine;

public class sairam_animator : MonoBehaviour

{
    public Animator animator;
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("trigger1");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("trigger2");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("trigger3");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("trigger4");
        }
    }
}
