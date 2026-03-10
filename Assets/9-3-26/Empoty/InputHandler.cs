using UnityEngine;
using UnityEngine.Events;

public class InputHandler : MonoBehaviour
{
    public UnityEvent OnSpacePressed;   

    public UnityEvent OnSpaceReleased;

    public UnityEvent OnAPressed;   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpacePressed?.Invoke();
        }

        if(Input.GetKeyUp(KeyCode.W))
        {
            OnSpaceReleased?.Invoke();
        }   

        if(Input.GetKeyDown(KeyCode.A))
        {
            OnAPressed?.Invoke();
        }
    }
}