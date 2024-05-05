using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_anim_up_down : MonoBehaviour
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
        if (npc.dirChange)
        {
            animator.Play("run_up");
        }
        else
        {

            animator.Play("run_down");
        }
    }

}
