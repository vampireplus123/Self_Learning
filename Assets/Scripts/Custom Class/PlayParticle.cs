using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticle : MonoBehaviour
{
   public ParticleSystem [] particle;
   public void playParticle(int index)
   {
    particle[index].Play();
   }
   public void StopParticle(int index){
    particle[index].Stop();
   }
}
