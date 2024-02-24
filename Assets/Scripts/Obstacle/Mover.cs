using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{   
    public float speed = 10.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Ver = Input.GetAxis("Vertical")*speed*Time.deltaTime;
        float hor = Input.GetAxis("Horizontal")*speed*Time.deltaTime;

        transform.Translate(hor, 0, Ver);
        
    }
}
