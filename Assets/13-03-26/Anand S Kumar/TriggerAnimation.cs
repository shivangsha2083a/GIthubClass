using System;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    public Animator animator;
    public float health = 1;

    private void Start()
    {
        animator.SetTrigger("die");
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetFloat("health", health);
        }
    }
}
