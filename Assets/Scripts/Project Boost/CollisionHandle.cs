using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandle : MonoBehaviour
{
    public float timeForLoad = 3f;
    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Respawn":
                Debug.Log("Start");
                break;
            case "Finish":
                Debug.Log("Finish game");
                startNext();
                break;
            case "Fuel":
                Debug.Log("+100");
                break;

            default:
                Debug.Log("Die");
                // ReloadScene(SceneManager.GetActiveScene().buildIndex);
                startCrash();
            break;
        }
    }

    
    void ReloadScene()
    {
        int indexSence = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(indexSence);
    }
    void NextLevel()
    {   
        int LevelIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSene = LevelIndex +1;
        if(nextSene == SceneManager.sceneCountInBuildSettings){
            nextSene = 0;
        }
        SceneManager.LoadScene(nextSene);
    }
    void startCrash()
    {
        GetComponent<Movement>().enabled = false;
        Invoke("ReloadScene",timeForLoad);
    }

    void startNext()
    {
        GetComponent<Movement>().enabled = false;
        Invoke("NextLevel",timeForLoad);
    }

}
