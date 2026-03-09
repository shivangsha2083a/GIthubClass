using UnityEngine;

public class FunctionAssign_Manish : MonoBehaviour
{
    public InputHandler inputHandler;
    public Player player;


    void Start()
    {
        inputHandler.OnSpacePressed.AddListener(player.Jump);
        inputHandler.OnSpacePressed.AddListener(player.Move);
    }
}
