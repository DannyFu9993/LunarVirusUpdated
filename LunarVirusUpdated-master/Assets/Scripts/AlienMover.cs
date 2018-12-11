using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMover : MonoBehaviour
{

    public Transform[] waypoints;
    int cur = 0;
    public float speed = 0.1f;



    void FixedUpdate()
    {
        // Waypoint not reached yet? then move closer
        if (transform.position != waypoints[cur].position)
        {
            Vector2 p = Vector2.MoveTowards(transform.position, waypoints[cur].position, speed);
            GetComponent<Rigidbody2D>().MovePosition(p);

        }

        // Waypoint reached, select next one


        else
            cur = (cur + 1) % waypoints.Length;

    }
}