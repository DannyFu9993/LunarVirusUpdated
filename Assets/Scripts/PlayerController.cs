using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class PlayerController : MonoBehaviour
{
=======
public class PlayerController : MonoBehaviour {
>>>>>>> 9bce5219a5f900ad4e6434ff0f2f475294c0d23d

    public float speed;
    public float jumpHeight;
    public GameObject laser;
<<<<<<< HEAD
    public GameObject laserSpawn;
    public float fireRate = 0.5f;
   
   
=======
    public float jumpTime;
    public GameObject laserSpawn;
    public float fireRate = 0.5f;
>>>>>>> 9bce5219a5f900ad4e6434ff0f2f475294c0d23d

    private Rigidbody2D rb2d;
    private float myTime = 0f;

<<<<<<< HEAD

    // Use this for initialization
    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();
       

    }
    
    // Update is called once per frame
    void Update()
    {
        myTime += Time.deltaTime;

        if (Input.GetButtonDown("Jump"))
        {
          


            rb2d.AddForce(Vector2.up * jumpHeight);



        }
        
        
        else 
             {
            rb2d.AddForce(-Vector2.up * jumpHeight);
            

            
        }
=======
    
    // Use this for initialization
	void Start () {

        rb2d = GetComponent<Rigidbody2D>();


    }
	
	// Update is called once per frame
	void Update () {
        myTime += Time.deltaTime;
         if (Input.GetButton("Jump"))
        {
             rb2d.AddForce(Vector2.up * jumpHeight);

         }
        else { rb2d.AddForce(-Vector2.up * jumpHeight); }
>>>>>>> 9bce5219a5f900ad4e6434ff0f2f475294c0d23d
        if (Input.GetButton("Fire1") && myTime > fireRate)
        {
            Instantiate(laser, laserSpawn.transform.position, laserSpawn.transform.rotation);
            myTime = 0.0f;
<<<<<<< HEAD


        }
      
=======
            
        }
        // Code for firing laser fire left side

        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    Instantiate(laser, laserSpawn.transform.position, laserSpawn.transform.rotation);
      //      myTime = 0.0f;
       // }

        //Code for firing laser fire left side
        /*
        if (Input.GetButton("a") && myTime > fireRate)
        {
            Instantiate(laser, laserSpawn.transform.position, laserSpawn.transform.rotation);
            myTime = 0.0f;
            speed = speed * -1;
        }
        */
>>>>>>> 9bce5219a5f900ad4e6434ff0f2f475294c0d23d



        Debug.Log(myTime);
<<<<<<< HEAD
        
=======
>>>>>>> 9bce5219a5f900ad4e6434ff0f2f475294c0d23d

    }

    void FixedUpdate()
    {
<<<<<<< HEAD
       
        float horiz = Input.GetAxis("Horizontal");

     



        Vector2 movement = new Vector2(horiz, 0);

      

        rb2d.velocity = movement * speed;
     
    }
 
    


}


=======
        float horiz = Input.GetAxis("Horizontal");
        
        //float jump = Input.GetAxis("Jump");

        

        //float verti = Input.GetAxis("Vertical");
        //verti += jumpHeight
        Vector2 movement = new Vector2(horiz,0);
        
        //rb2d.AddForce(transform.up * 10);
        
        rb2d.velocity = movement * speed;
    }



}
>>>>>>> 9bce5219a5f900ad4e6434ff0f2f475294c0d23d
