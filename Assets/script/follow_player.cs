using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_player : MonoBehaviour {
    public Transform player;
    public Vector3 offset= new Vector3(0.0f, 1.0f, -5.0f); //vector of 3 floats namely x,y and z values
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = player.position + offset; // moving the camera which is by default present at the center of th object
	}
}
