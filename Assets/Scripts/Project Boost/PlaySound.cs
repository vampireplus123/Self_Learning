using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;
using UnityEngine.UIElements;

public class PlaySound:MonoBehaviour
{
    // public AudioClip [] cliptoplay;
    AudioSource source;

    public AudioClip [] clip;
    
    void Start(){
        source = GetComponent<AudioSource>();
    }
    public void PlayTheClip(int index)
    {
        // clip must follow this struture:
        //  + First for the main 
        //  + Every next sound is just for specific problem
        source.PlayOneShot(clip[index]);
    }
}
