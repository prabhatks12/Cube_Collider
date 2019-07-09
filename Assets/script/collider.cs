using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collider : MonoBehaviour {

    public player_script movement;
   

	public void OnCollisionEnter(Collision collisioninfo)
    {

        if (collisioninfo.collider.tag == "Obstacle")
        {
            Debug.Log("WE HIT AN OBSTACLE");
            movement.enabled = false;
            FindObjectOfType<GameMan>().EndGame();
            

        }
    }

   
}
