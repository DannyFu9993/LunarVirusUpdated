using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroybycontactP : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        // Ignore the boundary collider
        if (other.tag == "Boundary")
        {
            Debug.Log(other.gameObject.name + " Check");
            return;
        }


        // Create the asteroid explosion

        Destroy(other.gameObject);
        Destroy(this.gameObject);
    }
}
