using UnityEngine;

public class FunctionAssigner_Mukul : MonoBehaviour
{
    [SerializeField]InputHandler InputHandler;
    [SerializeField]Player player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //InputHandler.OnSpacePressed.AddListener(player.Jump);
        //InputHandler.OnSpacePressed.AddListener(player.Move);
    }
}
