﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Welcome : MonoBehaviour {

	// Use this for initialization
	public void StartGame () {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

	}
	
	
}
