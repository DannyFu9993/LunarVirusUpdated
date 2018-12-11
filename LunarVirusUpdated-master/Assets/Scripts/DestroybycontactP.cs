using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroybycontactD : MonoBehaviour
{
    public GameController gameControllerscipt;

    void OnTriggerEnter2D(Collider2D other)
    {





        DontDestroyOnLoad(this.gameObject);
        if (other.tag == "Astronaut")
        {
            // Trigger Game Over logic
            gameControllerscipt.GameOver();
        }

    }
}
