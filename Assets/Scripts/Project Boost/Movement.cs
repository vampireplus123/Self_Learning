using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float thurst = 5f;
    public float RotateSpeed = 20f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerThrust();
        PlayerRotation();
    }
    void PlayerThrust()
    {
        if(Input.GetKey(KeyCode.Space)){
            Debug.Log("Space pressed");
            rb.AddRelativeForce(Vector3.up*thurst*Time.deltaTime);
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
}