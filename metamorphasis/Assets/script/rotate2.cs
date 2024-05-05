using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_anim_left_right2 : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    NPC npc;
    void Start()
    {
        animator = GetComponent<Animator>();
        npc = GameObject.FindGameObjectWithTag("NPC").GetComponent<NPC>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(npc.dirChange)
        {
            animator.Play("NPC3_run_left");
        }
        else
        {

            animator.Play("NPC3_run_right");
        }
    }

}
