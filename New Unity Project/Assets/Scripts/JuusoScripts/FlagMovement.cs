﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagMovement : MonoBehaviour
{

    GameObject player;

    //public AudioClip audioClip;

    public AudioSource source;

	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        //source.clip = audioClip;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Endurance enduScript = player.GetComponent<Endurance>();

        if (enduScript.flag == true)
        {
            if (transform.position.y <= 7.30)
            {
                player.GetComponent<Endurance>().FlagPoleTimer(false);

                if (Input.GetKeyDown(KeyCode.A))
                {
                    transform.Translate(Vector2.up * Time.deltaTime * enduScript.flagPower, Space.World);
                    //SoundManager.PlaySound("Winching");
                    if (!source.isPlaying)
                    {
                        source.Play();
                    }
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    transform.Translate(Vector2.up * Time.deltaTime * enduScript.flagPower, Space.World);
                    /*if (!source.isPlaying)
                    {
                        //source.Play();
                    }*/
                }
            }
            else if (transform.position.y > 7.30)
            {
                SceneManager.LoadScene("YouWon");
            }
        }

        if (transform.position.y > 1.48 && transform.position.y <= 7.30)
        {
            transform.Translate(Vector2.down * Time.deltaTime * enduScript.flagDrop, Space.World);
        }

    }
}
