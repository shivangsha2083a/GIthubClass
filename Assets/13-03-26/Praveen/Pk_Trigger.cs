using UnityEngine;

public class Pk_Trigger : MonoBehaviour
{
    public Animator animator;
    public int health;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("die");
        }
        //
        animator.SetFloat("health", health);
    }
}
