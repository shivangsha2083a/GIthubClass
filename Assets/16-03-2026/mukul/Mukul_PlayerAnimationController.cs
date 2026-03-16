using UnityEngine;

public class Mukul_PlayerAnimationController : MonoBehaviour
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

        animator.SetFloat("X", horizontalInput);
        animator.SetFloat("Y", verticalInput);
    }
}