using UnityEngine;

public class Function_assigner_pratyush : MonoBehaviour
{
    public InputHandler inputhandler;
    public Player player;
    void Start()
    {
        inputhandler.OnSpacePressed.AddListener(player.Jump);
        inputhandler.OnSpacePressed.AddListener(player.Move);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
