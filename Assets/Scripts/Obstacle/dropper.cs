using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropper : MonoBehaviour
{
    public float dropTime = 3.0f;
    Rigidbody rid;
    MeshRenderer render;
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        rid = GetComponent<Rigidbody>();

        render.enabled = false;
        rid.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > dropTime){
            render.enabled = true;
            rid.useGravity = true;
            // Debug.Log("Dropped!");
        }
    }
    
}
