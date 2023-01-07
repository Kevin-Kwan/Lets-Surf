using Fragsurf.Movement;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startLevel : MonoBehaviour
{
    public bool started;
    
   
    public GameObject bhopper;
    public DisplayTime getthetime;
    float deltaTime = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        started = false;
        //script for the start area, and since the player hasnt crossed the start line to start the timer, boolean started is false
    }

    // Update is called once per frame
    void Update()
    {
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;

    }

    private void OnTriggerExit(Collider collision)
    {//when the player exits the starting/safe area, boolean started changes to true and the timer instantiated in DisplayTime is started (nextLevel)
        if (collision.tag == "jumpy")
        {
            started = true;
            getthetime.timer.Start();
            this.GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);
        }

        //show time and a UI
        //if level beaten (boolean) and press enter

    }
    
    void OnGUI()
    {
        int w = Screen.width, h = Screen.height;

        GUIStyle style = new GUIStyle();

        Rect rect = new Rect(0, 0, w, h * 2 / 100);
        style.alignment = TextAnchor.UpperRight;
        style.fontSize = h * 2 / 100;
        style.normal.textColor = new Color(0.0f, 0.0f, 0.5f, 1.0f);
        float msec = deltaTime * 1000.0f;
        float fps = 1.0f / deltaTime;
        string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
        GUI.Label(rect, text, style);
    }
}