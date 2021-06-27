using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour
{ GameObject gameOVER;
    public AudioSource newSong;
    public AudioSource deathSong;
    Boolean deathPlaying;
    public GameObject[] balls;
    

    
    private void Start()
    {
        ScoreScript.scoreValue = 0;
        gameOVER = GameObject.Find("game over");

        balls = GameObject.FindGameObjectsWithTag("ball");
            newSong.Play();
        //balls = GameObject.Find("ball");
        deathPlaying = false;
  
        Debug.Log("yo");
    }
    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
    }
    private void FixedUpdate()
    {

        balls = GameObject.FindGameObjectsWithTag("ball");
        
        if (balls.Length == 0)
        {
            

            if (newSong.isPlaying&&deathPlaying==false)
            {
                Instantiate(gameOVER, new Vector3(0, 0, 0), Quaternion.identity);
                Debug.Log("yo");
                newSong.Stop();
                deathSong.Play();
                
                deathPlaying = true;

            }

            

        }
    }
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
    }

}