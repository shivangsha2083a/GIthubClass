using UnityEngine;

public class Enemy_mukul : MonoBehaviour, IDamageable
{
    int counter = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        Debug.Log("enemy getting damage. health -" +  damage);

        
        counter ++;

        if (counter == 5)
        {
            Die();
        }
    }

    public void Die() 
    {
        print("i am dead ;)");
    }
}
