using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_anim_up_down3 : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    enemy em;
    void Start()
    {
        animator = GetComponent<Animator>();
        em = GameObject.FindGameObjectWithTag("enemy").GetComponent<enemy>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (em.dirChange == true)
        {
            animator.Play("enemy_up");
        }
        else
        {

            animator.Play("enemydown");
        }
    }

}
