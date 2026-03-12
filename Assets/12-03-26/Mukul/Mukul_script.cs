using UnityEngine;

public class Mukul_script : MonoBehaviour
{
    [SerializeField] ScriptableObject so;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(so.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
