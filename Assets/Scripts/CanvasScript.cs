using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasScript : MonoBehaviour
{
   public string sceneName;
    public AudioSource bgm;
    
    public void PlayGame()
    {
            SceneManager.LoadScene(sceneName);
    }
    public void levselect()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    void Start()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Application.targetFrameRate = 300;
    }
    void Update()
        {


        
        
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