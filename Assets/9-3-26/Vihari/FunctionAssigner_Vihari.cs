using UnityEngine;

public class FunctionAssigner_Vihari : MonoBehaviour
{
    public InputHandler inputHandler;
    public p1 p1;
    public Enemy_Vihari enemyVihari;

    public void Start()
    {
        // inputHandler = GetComponent<InputHandler>();
        // player = GetComponent<Player>();
        inputHandler.OnSpacePressed.AddListener(p1.Jump);
    }
}
