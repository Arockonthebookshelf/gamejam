using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Transform[] waypoints;
    public float moveSpeed = 3f;
    private int currentWaypointIndex = 0;
    public bool dirChange = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveBetweenWaypoints();
    }

    void MoveBetweenWaypoints()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, moveSpeed * Time.deltaTime);
        if (Vector2.Distance(transform.position, waypoints[currentWaypointIndex].position) < 0.1f)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            dirChange = !dirChange;
        }
    }
}
