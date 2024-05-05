using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop_handler : MonoBehaviour
{
    // Start is called before the first frame update
    drop drop;
    bool drop_button;
    void Start()
    {
        drop = GameObject.FindGameObjectWithTag("slot").GetComponent<drop>();
    }

    // Update is called once per frame
    void Update()
    {
        drop_button = Input.GetKeyDown(KeyCode.Q);
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            drop.i = 0;
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            drop.i = 1;
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            drop.i = 3;
        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            drop.i = 4;
        }
        if(drop.i == 3)
        {
            Debug.Log("0");
        }
        else if(drop.i == 2)
        {
            Debug.Log("1");
        }
    }
    private void FixedUpdate()
    {
        if (drop_button)
        {
            drop.dropitem();
        }
        Debug.Log(drop_button);
    }
}
