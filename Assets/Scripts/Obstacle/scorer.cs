using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorer : MonoBehaviour
{
  int hits = 0;    
  void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.tag != "Hit"){
      hits++;
      Debug.Log("You've bumped into a thing this many times: " + hits); 
    }
  }
}
