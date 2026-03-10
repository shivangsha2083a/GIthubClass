using UnityEngine;

public class BallJump : MonoBehaviour
{
    Rigidbody rb;
    public AudioSource sound;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseDown()
    {
        rb.AddForce(Vector3.up * 300);
        sound.Play();
    }
}