using System;
using UnityEngine;

public class FunctionAssigner_Anand : MonoBehaviour
{
    public InputHandler inputHandler;
    public Player player;

    private void Start()
    {
        inputHandler.OnSpacePressed.AddListener(player.Jump);
    }
}
