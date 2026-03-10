using UnityEngine;

public class functionassign_sairam : MonoBehaviour
{
    public InputHandler inputHandler;
    public Player player;


    void Start()
    {
        inputHandler.OnSpacePressed.AddListener(player.Jump);
        inputHandler.OnSpacePressed.AddListener(player.Move);
    }
}
