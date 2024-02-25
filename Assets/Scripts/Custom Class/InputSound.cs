using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSound : MonoBehaviour
{
    public void SpaceWithSound(string KeyName)
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            GetComponent<AudioSource>().Play();
        }
    }
}
