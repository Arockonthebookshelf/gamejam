using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class regen_area : MonoBehaviour
{
    public player_health playerHealth;
    public GameObject player;
    public float regen = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        deduction();
    }

    void deduction()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < regen)
        {
            playerHealth.health = Mathf.Clamp(playerHealth.health + 1 * Time.deltaTime, 0, 100);
        }
        if (Vector3.Distance(player.transform.position, transform.position) > regen)
        {
            playerHealth.health = Mathf.Clamp(playerHealth.health - 1 * Time.deltaTime, 0, 100);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, regen);
    }
}

