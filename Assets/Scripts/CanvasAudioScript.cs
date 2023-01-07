using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasAudioScript : MonoBehaviour
{
   
    public AudioSource bgm;
    
    
    public void QuitGame()
    {
        Application.Quit();
    }
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("moosic");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
    void Update()
        {


        if (SceneManager.GetActiveScene().name != "MainMenu")
        {
            if (SceneManager.GetActiveScene().name != "LevelSelect")
            { 
            Destroy(this.gameObject); }
        }
        if (Input.anyKey)
        {
            if (Input.GetKeyDown("escape"))
            {
                Application.Quit();
            }
            //else
            //{
               // SceneManager.LoadScene(sceneName);
           // }
            }
        }

    
            
}