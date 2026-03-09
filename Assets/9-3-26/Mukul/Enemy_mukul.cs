using UnityEngine;

public class StrongerEnemy_mukul : MonoBehaviour, IDamageable
{
    int count = 0;
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
        count++;
        if (count <= 5) 
        {
            Debug.Log("blocked");
        }
        else if (count <= 9)
        {
            Debug.Log("enemy getting damage. health -" + damage);
        }
        else if (count == 10)
        {
            Die();
        }
    }

    public void Die() 
    {
        print("i am dead ;)");
    }
}
