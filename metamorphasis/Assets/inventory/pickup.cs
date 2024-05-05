using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    private inventory_item inventory;
    public GameObject item_icon;
    public GameObject potion;
    bool mouseclick;
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory_item>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        /*mouseclick =Input.GetMouseButton(0);
        Debug.Log(mouseclick);*/
        
    }

   
    private void OnTriggerStay2D(Collider2D collision)
    {
        //if(collision.CompareTag("Player") && mouseclick)
        if (collision.CompareTag("Player"))
        {
            if (Input.GetMouseButtonDown(0))
            { 
            for (int i = 0; i < inventory.slots.Length; i++)
                {
                    if (inventory.isfull[i] == false)
                    {
                        inventory.isfull[i] = true;
                        Instantiate(item_icon, inventory.slots[i].transform, false);
                        if (i == 0)
                        {
                            inventory.isfull[3] = true;
                            Instantiate(potion, inventory.slots[3].transform, false);
                        }
                        Destroy(gameObject);
                        break;
                    }
                }
            }
        }
    }
}
