using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustParticle;

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            dustParticle.Play();
        }    
    }

    void onCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            dustParticle.Stop();
        }    
    }
}
