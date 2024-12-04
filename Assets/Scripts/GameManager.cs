using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource audioManager;
    void Start()
    {
        audioManager = GameObject.Find("Audio").GetComponent<AudioSource>();
        if(audioManager.isPlaying){
            return;
        }
        else{
            audioManager.Play();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
