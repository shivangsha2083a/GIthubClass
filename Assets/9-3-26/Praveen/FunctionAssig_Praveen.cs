using UnityEngine;
using UnityEngine.Events;

public class FunctionAssig_Praveen : MonoBehaviour
{
    public UnityEvent OnSpacePressed;

    void Start()
    {
        Player player = FindObjectOfType<Player>();
        OnSpacePressed.AddListener(player.Jump);
    }
    //
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpacePressed?.Invoke();
        }
    }
}