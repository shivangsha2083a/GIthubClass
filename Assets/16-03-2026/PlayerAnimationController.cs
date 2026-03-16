using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        animator.SetFloat("xfloat", horizontalInput);
        animator.SetFloat("yfloat", verticalInput);
    }
}