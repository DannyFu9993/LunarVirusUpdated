using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroybycontactD : MonoBehaviour
{
<<<<<<< HEAD
    public GameController gameControllerscipt;
=======
>>>>>>> 9bce5219a5f900ad4e6434ff0f2f475294c0d23d

    void OnTriggerEnter2D(Collider2D other)
    {





        DontDestroyOnLoad(this.gameObject);
<<<<<<< HEAD
        if (other.tag == "Astronaut")
        {
            // Trigger Game Over logic
            gameControllerscipt.GameOver();
        }

=======
       
>>>>>>> 9bce5219a5f900ad4e6434ff0f2f475294c0d23d
    }
}
