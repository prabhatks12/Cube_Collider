using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMan : MonoBehaviour {

    bool GameEnd = false;
    public GameObject gameObject;

    public float RestartDelay = 2f; //2 secs
    public void EndGame() {

        if(GameEnd==false)
        {
            GameEnd = true;
            Debug.Log("Game Over");
            Invoke("Restart",RestartDelay);
        }
    }

    public void Restart()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        Debug.Log("Level  Completed");
       gameObject.SetActive(true);
    }
}
