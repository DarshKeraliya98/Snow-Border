using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreachDetactor1 : MonoBehaviour
{
    [SerializeField] float loadDely = 0.5f;
    [SerializeField] ParticleSystem crechPlayer;
    [SerializeField] AudioClip crashSFX;

    bool hasCrashed = false;

     void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground" && !hasCrashed){
            hasCrashed = true;
            crechPlayer.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("RelodeScene",loadDely);
        }
    }

    void RelodeScene()
    {
        SceneManager.LoadScene(0);
    }
}
