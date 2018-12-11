using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    // Variable declarations
    public float speed;

    private Rigidbody2D rBody;

	// Use this for initialization
	void Start () {
        rBody = GetComponent<Rigidbody2D>();
        rBody.velocity = transform.right * speed;

         //&& Input.GetButton("Fire1")
         /*
        if (Input.GetButton("Horizontal"))
        {
            rBody.velocity = transform.right * speed * -1f;
        }
        */

        if (Input.GetAxis("Horizontal") < 0)
        {
            rBody.velocity = transform.right * speed * -1f;
        }


        /*
        bool lookingLeftSide = false;
        while ((Input.GetKeyDown(KeyCode.A) == true))
        {
            lookingLeftSide = true;
        }

        if (lookingLeftSide == true) ;
        {
            rBody.velocity = transform.right * speed * -1f;
        }
        */

    }
}
