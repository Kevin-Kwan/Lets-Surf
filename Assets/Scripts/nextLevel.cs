using Fragsurf.Movement;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    public bool finished;
    public Text whattodonext;
    private bool finishedbefore;
    public static float highestScoreValue = 0;
    public GameObject bhopper;
    public DisplayTime getthetime;
    public TimeSpan besttime;
    string key;
    AudioClip yay;
    

    public float sceneBestTime;
    // Start is called before the first frame update
    void Start()
    {//when a level first loads, the player hasnt completed the level yet, so boolean finished is false
        finished = false;

        //sceneBestTime = PlayerPrefs.GetFloat("CurrentBestTime", sceneBestTime);
        Application.targetFrameRate = 300;

        key = SceneManager.GetActiveScene().buildIndex.ToString();
        //UnityEngine.Debug.Log(key);
        if (PlayerPrefs.HasKey(key))
            //see if key exists in preferences
        {
            sceneBestTime = PlayerPrefs.GetFloat(key);
            //store player's best time corresponding to key in the preference file as a float
            //UnityEngine.Debug.Log(sceneBestTime);
            besttime = TimeSpan.FromMilliseconds(PlayerPrefs.GetFloat(key));
            //store player's best time corresponding to key in the preference file as a TimeSpan since we are using a timer

        }
        //if the key doesn't exist (player hasnt played level yet), the float value will automatically be 0 by default
    }
    
    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.M)))
        {
            SceneManager.LoadScene("MainMenu");
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("LevelSelect");
        }
        if (Input.GetKeyDown(KeyCode.F) && finished == true)
        {   if ((SceneManager.GetActiveScene().buildIndex + 1)==-1)
            {
                UnityEngine.Debug.Log("not done yet!");
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            PlayerPrefs.SetFloat(key, 0f);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            PlayerPrefs.DeleteKey(key);
        }
    }


    private void OnTriggerEnter(Collider collision) //talk about displaytime first timer
        //for nextLevel, which is the script attached to the end area, when the player enters the finish area and completes the level, finished is true
    {
        if (collision.tag == "jumpy")
        { 
        finished = true;
            this.GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);
        //the stopwatch instantiated in DisplayTime will be stopped
        getthetime.timer.Stop();
            //UnityEngine.Debug.Log(PlayerPrefs.GetFloat(key, sceneBestTime));
           
           
            //store the time elapsed from the stopwatch and covert the time into total amount of milliseconds as a float
            float timeTaken=(float)getthetime.timer.Elapsed.TotalMilliseconds;
            //UnityEngine.Debug.Log(timeTaken);
            //from earlier, we will compare the scene/level's best time with the elapsed time of the current run. so if the elapsed time is faster than the
            //level's best time, we will replace the best time. also, if the best time was 0, meaning that there wasnt a best time before on this level, we will
            //set the elapsed time as the new best time
            if (sceneBestTime==0|| timeTaken < sceneBestTime)
            {
                //UnityEngine.Debug.Log("YEP");
                PlayerPrefs.SetFloat(key, timeTaken);
              //set the key's new float being time elapsed representing the level's new best time
            }
            // in order to display the time on the level end screen and during gameplay, we convert the float besttime into a Timespan, 
            //and format the elapsed time and best time into a string of minutes, seconds, and milliseconds
            besttime = TimeSpan.FromMilliseconds(PlayerPrefs.GetFloat(key));
            whattodonext.text = "You beat this course!\n\nYour Best Time: " + string.Format("{0:00}:{1:00}:{2:00}", besttime.Minutes, besttime.Seconds, besttime.Milliseconds) + "\nYour Time: " + string.Format("{0:00}:{1:00}:{2:00}", getthetime.timer.Elapsed.Minutes, getthetime.timer.Elapsed.Seconds, getthetime.timer.Elapsed.Milliseconds) + "\n\nPress F to move onto the next level!";

        }

        
        //show time and a UI
        //if level beaten (boolean) and press enter
       
    }
}