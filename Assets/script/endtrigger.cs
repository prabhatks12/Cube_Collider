using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endtrigger : MonoBehaviour {

    public GameMan gamemanager;

	void OnTriggerEnter()
    {
        gamemanager.CompleteLevel();

    }
}
