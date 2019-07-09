using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_script : MonoBehaviour {

    public Rigidbody rb;
    public float forwardforce=60000f;
    public float sideforce = 100f;


    //rb.useGravity=false for disabling gravity 
    // Use this for initialization
    void Start () {

        Debug.Log("Hello Wrold");
        rb.AddForce(0, 0, forwardforce*Time.deltaTime);
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("d"))
        {

            rb.AddForce(sideforce * Time.deltaTime,0,0,ForceMode.VelocityChange); //velocitychange to add velocity to the object in the dorection where its moving 

        }
        else if(Input.GetKey("a"))
        {
            rb.AddForce(-sideforce * Time.deltaTime,0,0, ForceMode.VelocityChange);

        }
        else if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, sideforce * Time.deltaTime, ForceMode.VelocityChange);

        }
        if (rb.position.y < -2f)
        {
            FindObjectOfType<GameMan>().EndGame();

        }
    }
}
