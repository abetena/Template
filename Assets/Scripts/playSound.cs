using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSound : MonoBehaviour

{
    public AudioSource audioSource;
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    //when you walk away
    private void OnTriggerExit(Collider other)
    {
    //turn off legend
    audioSource.Stop();
    }
}