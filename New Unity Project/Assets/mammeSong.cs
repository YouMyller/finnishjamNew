using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mammeSong : MonoBehaviour {

    public AudioSource audioSource;
    public Transform lippu;

    // Use this for initialization
    void Start()
    {
        //audioSource.clip = maamme;	
        audioSource.volume = 0;
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = lippu.position.y / 12;
        if (lippu.position.y < -2.0)
        {
            audioSource.volume = 0;
        }
    }
}
