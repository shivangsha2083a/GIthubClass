using System;
using UnityEngine;

public class FunctionAssigner_Ravi : MonoBehaviour
{
    public Player player;
    public InputHandler inputHandler;

    private void Start()
    {
        inputHandler.OnSpacePressed.AddListener(player.Jump);
        inputHandler.OnSpacePressed.AddListener(player.Move);
    }
}
