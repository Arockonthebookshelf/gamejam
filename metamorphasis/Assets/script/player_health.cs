using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_health : MonoBehaviour
{
    public float health;
    public float maxHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        if (health <= 0)
        {
            DestroyPlayer();
        }
    }

    void DestroyPlayer()
    {
        Destroy(gameObject);
    }
}
