using System;
using UnityEngine;

public class Enemy_Praveen : MonoBehaviour, IDamageable
{
    [SerializeField] private int damage;
    [SerializeField] private int health;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TakeDamage(damage);
        //
        if (health <= 0)
        {
            Die();
        }
    }

    public void TakeDamage(int damage)
    {
        Debug.Log($"Take Damage + {damage}");
        health -= damage;
    }
    //
    public void Die()
    {
        Debug.Log("Enemy Death");
    }
}
