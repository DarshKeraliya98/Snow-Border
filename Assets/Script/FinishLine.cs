using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float dely = 1f;
    [SerializeField] ParticleSystem finishEffect;
   void OnTriggerEnter2D(Collider2D other) 
   {
        if(other.tag == "Player")
        {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();           
            Invoke("RelodeScene", dely);
            
        }
   }
   void RelodeScene()
   {
        SceneManager.LoadScene(0);
   }
}
