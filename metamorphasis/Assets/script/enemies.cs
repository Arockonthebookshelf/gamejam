using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemies : MonoBehaviour
{
    public Transform[] waypoints;
    public float moveSpeed = 3f;
    public float detectionRange = 5f;
    public GameObject player;
    public GameObject bulletPrefab;
    public Transform firePoint;
    private player_health health;
    public float fireRate = 1f;
    private float nextFireTime;
    private int currentWaypointIndex = 0;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        nextFireTime = Time.time;
        health = player.GetComponent<player_health>();
    }

    void Update()
    {
        if (player != null && Vector2.Distance(transform.position, player.transform.position) <= detectionRange)
        {

            ShootPlayer();
            health.health = health.health - 20;
        }
        else
        {

            MoveBetweenWaypoints();
        }
    }

    void MoveBetweenWaypoints()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, moveSpeed * Time.deltaTime);
        if (Vector2.Distance(transform.position, waypoints[currentWaypointIndex].position) < 0.1f)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }
    }

    void ShootPlayer()
    {
        if (Time.time >= nextFireTime)
        {

            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
            Vector2 direction = (player.transform.position - firePoint.position).normalized;
            bullet.GetComponent<Rigidbody2D>().velocity = direction * 10f;

            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detectionRange);
    }
}
