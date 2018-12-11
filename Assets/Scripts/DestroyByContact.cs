using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class DestroyByContact : MonoBehaviour
{

    public GameObject explosionAsteroid;
    public GameObject explosionPlayer;
  

    public GameController gameControllerScript;

    // Use this for initialization
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");

        if (gameControllerObject != null)
        {
            gameControllerScript = gameControllerObject.GetComponent<GameController>();
        }
        if (gameControllerScript == null)
        {
  
        }
    }
=======
public class DestroyByContact : MonoBehaviour {

    public GameObject explosionAsteroid;
    public GameObject explosionPlayer;

	// Use this for initialization
	void Start () {
		
	}
>>>>>>> 9bce5219a5f900ad4e6434ff0f2f475294c0d23d

    // This trigger will run code when another object with a collider whose "Is Trigger?" boolean is set to true,
    // and colliders with this object
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boundary")
        {
            // Debug.Log(other.gameObject.name + "HIT ME!!!!");
            return;
        }

<<<<<<< HEAD
        if (other.tag == "Astronaut")
        {

            Instantiate(explosionPlayer, other.transform.position, other.transform.rotation);
            // Trigger Game Over logic
            gameControllerScript.GameOver();

        }

        Instantiate(explosionAsteroid, this.transform.position, this.transform.rotation);
      

=======
        if (other.tag == "Player")
        {
            Instantiate(explosionPlayer, other.transform.position, other.transform.rotation);
            // Trigger Game Over logic
        }

        Instantiate(explosionAsteroid, this.transform.position, this.transform.rotation);
        
>>>>>>> 9bce5219a5f900ad4e6434ff0f2f475294c0d23d
        Destroy(other.gameObject);
        Destroy(this.gameObject);
    }
}
