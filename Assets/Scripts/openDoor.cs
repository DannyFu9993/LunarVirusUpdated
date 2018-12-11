using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour {
    GameObject door;

    bool getKey;
    void Start()
    {
        getKey = false;
    }

    public void havingKey()
        {
        getKey = true;

    }

    void OnTriggerEnter2D(Collider2D co)
    {

        door = GameObject.FindGameObjectWithTag("Door");
        if (co.tag == "Door" && getKey == true)
        {
         Destroy(co.gameObject);
            getKey = false;
        }

        
       
       
            
           
     
    }
     
}
