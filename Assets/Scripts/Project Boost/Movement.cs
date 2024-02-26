using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float thurst = 5f;
    public float RotateSpeed = 20f;
    public float fuel = 100f;
    public AudioClip Engine;
    Rigidbody rb;
    AudioSource audioSource;
    PlaySound playClip;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        playClip = GetComponent<PlaySound>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerThrust();
        PlayerRotation();
    }
    void PlayerThrust()
    {
        /* if(audioSource.isPlaying){
            audioSource.Stop();
         }else if (!audioSource.isPlaying && Input.GetKey(KeyCode.Space)){
             Debug.Log("Space pressed");
             rb.AddRelativeForce(Vector3.up*thurst*Time.deltaTime);
             audioSource.Play();
        } */
        if (Input.GetKey(KeyCode.Space)){
            rb.AddRelativeForce(Vector3.up*thurst*Time.deltaTime);
            powerPlaiyer();
            if(!audioSource.isPlaying)
            {
                playClip.PlayTheClip(0);
            }
           
         }
        else
        {
            audioSource.Stop();
        }
       
    }
    void PlayerRotation(){
        if(Input.GetKey(KeyCode.A))
        {
            RotateThurst(RotateSpeed);
        }
        else if(Input.GetKey(KeyCode.D)){
            RotateThurst(-RotateSpeed);
        }
    }

    private void RotateThurst(float rotatePlayer)
    {   
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * rotatePlayer * Time.deltaTime);
        rb.freezeRotation = false;
    }
    
    public void incresePowerOfPlayer(float newfuel)
    {
        fuel= newfuel;
        if(fuel > 100){
            fuel = 100;
        }
    }
    void powerPlaiyer(){
       fuel-=10*Time.deltaTime; 
       if(fuel <=0){
        GetComponent<Movement>().enabled = false;
       }
    }

}
