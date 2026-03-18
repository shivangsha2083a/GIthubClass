using UnityEngine;

public class Harshith : MonoBehaviour
{
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("Idle");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("Move");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("Death");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("Damage");
        }
    }
}
