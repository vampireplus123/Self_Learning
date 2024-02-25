using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandle : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Respawn":
                Debug.Log("Start");
                break;
            case "Finish":
                Debug.Log("Finish game");
                NextLevel(SceneManager.GetActiveScene().buildIndex);
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

    void startCrash()
    {
        GetComponent<Movement>().enabled = false;
        Invoke("ReloadScene",1f);
        
    }
    void ReloadScene()
    {
        
        int indexSence = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(indexSence);
    }
    void NextLevel(int LevelIndex)
    {   
        int nextSene = LevelIndex +1;
        if(nextSene == SceneManager.sceneCountInBuildSettings){
            nextSene = 0;
        }
        SceneManager.LoadScene(nextSene);
    }

}
