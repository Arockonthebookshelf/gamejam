using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class spawn : MonoBehaviour
{
    public GameObject item; // The item to spawn
    private Transform player; // Reference to the player's transform
  

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; // Find the player object
    }

    // Function to spawn a dropped item
    public void spawndroppeditem()
    {
        // Calculate the spawn position slightly above the player's position
        Vector2 spawnPos = new Vector2(player.position.x, player.position.y + 1);

        // Instantiate the item at the calculated spawn position
       // Instantiate(item, spawnPos, Quaternion.identity);
    }

   
}
