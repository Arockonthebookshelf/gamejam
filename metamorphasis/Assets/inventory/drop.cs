using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class drop : MonoBehaviour
{
    inventory_item inventory;
    public int i;
    public Transform potionButton;

    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory_item>();
    }

    void Update()
    {
        // If there are no child objects (items) in this object (inventory slot)
        if (transform.childCount <= 0)
        {
            // Set the corresponding slot in the inventory to be not full
            inventory.isfull[i] = false;
        }
    }

    // Function to drop the item
    public void dropitem()
    {
        // Loop through each child object (item) in this object (inventory slot)
        foreach (Transform child in transform)
        {
            // Call the spawndroppeditem function from the spawn component attached to the child
            child.GetComponent<spawn>().spawndroppeditem();

            // Destroy the child object (item)
            GameObject.Destroy(child.gameObject);
        }
        potion_making.potion.SetActive(true);
        potionButton.gameObject.SetActive(true);
       
    }
    public void onClickPotion()
    {
        potion_making.potion.SetActive(false);
        potionButton.gameObject.SetActive(false);
    }
}
