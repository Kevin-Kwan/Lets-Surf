using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Diagnostics;
using System;
using UnityEngine.SceneManagement;

namespace Fragsurf.Movement

{
    public class DisplayTime : MonoBehaviour
    {
        
        private bool start=true;
        public SurfCharacter jumpy;
        public Stopwatch timer;
        public startLevel starting;
        public nextLevel level;
        TimeSpan besttime;
        public float sceneBestTime;
        string key;



        Text speed;
        void Start()
        {
            key = SceneManager.GetActiveScene().buildIndex.ToString();
            if (PlayerPrefs.HasKey(key))
            {
                besttime = TimeSpan.FromMilliseconds(PlayerPrefs.GetFloat(key));

            }
            timer = new Stopwatch(); //in the start method, we create a new stopwatch whenever a new level is loaded, so the level time always starts at 0
            speed = GetComponent<Text>();
        }

        // Update is called once per frame
        private void Update()
        {
            speed.text = "Best Time: "+ string.Format("{0:00}:{1:00}:{2:00}", besttime.Minutes, besttime.Seconds, besttime.Milliseconds)+"\nYour Time: "+ string.Format("{0:00}:{1:00}:{2:00}", timer.Elapsed.Minutes, timer.Elapsed.Seconds, timer.Elapsed.Milliseconds);
            
        }
    }
}