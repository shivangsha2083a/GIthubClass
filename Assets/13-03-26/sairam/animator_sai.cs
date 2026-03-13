using UnityEngine;
using UnityEngine.UIElements;

public class animator_sai : MonoBehaviour
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
