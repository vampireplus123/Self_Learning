using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandle : MonoBehaviour
{
    public float timeForLoad = 3f;
    GameObject destroyGameObject;
    PlaySound playclip;
    PlayParticle playTheParticle;
    bool isTransition = false;
    /* First clip is for using the Die
    Second clip is finish the Level */

    void Start(){
        destroyGameObject = GameObject.FindWithTag("Fuel");
        playclip = GetComponent<PlaySound>();
        playTheParticle = GetComponent<PlayParticle>();
    }
    void OnCollisionEnter(Collision other)
    {
        if(isTransition)
        { 
            return; 
            }
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
                Destroy(destroyGameObject);
                GetComponent<Movement>().incresePowerOfPlayer(100);
                break;

            default:
                Debug.Log("Die");
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
        playTheParticle.playParticle(1);
        isTransition = true;
        playclip.PlayTheClip(1);
        GetComponent<Movement>().enabled = false;
        Invoke("ReloadScene",timeForLoad);
    }

    void startNext()
    {   
        playTheParticle.playParticle(0);
        isTransition = true;
        playclip.PlayTheClip(2);
        GetComponent<Movement>().enabled = false;
        Invoke("NextLevel",timeForLoad);
    }

}
