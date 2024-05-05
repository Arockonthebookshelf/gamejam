using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    float hor;
    float vert;
    string currentidle;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        if(hor > 0.1f)
        {
            animator.Play("run_right");
            currentidle = "idle_right";
        }
        else if(hor <-0.1f)
        {
            animator.Play("run_left");
            currentidle = "idle_left";
        } else if(vert > 0.1f)
        {
            animator.Play("run_up");
            currentidle = "idle_up";
        } else if(vert < -0.1f)
        {
            animator.Play("rundown");
            currentidle = "idle_down";
        }
        else
        {
            animator.Play(currentidle);
        }
    }
}
