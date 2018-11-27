using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroybycontactD : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {





        DontDestroyOnLoad(this.gameObject);
       
    }
}
