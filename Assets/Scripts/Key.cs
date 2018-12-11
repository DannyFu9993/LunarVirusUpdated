using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {
    private GameObject mc;
    GameObject door;
  

    void OnTriggerEnter2D(Collider2D co)
    {
        mc = GameObject.Find("Astronaut");
        door = GameObject.Find("openDoor");
       
        if (co.name == "Astronaut")

            Destroy(gameObject);
        door.GetComponent<openDoor>().havingKey();
   
    
        



    }
}
