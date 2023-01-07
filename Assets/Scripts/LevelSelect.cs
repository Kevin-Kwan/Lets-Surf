using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
   public string Level;
    public AudioSource bgm;
    public void PlayGame()
    {
            SceneManager.LoadScene(Level);
    }
    public void GoMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
     void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 1;
        Application.targetFrameRate = 300;

    }
    public void QuitGame()
    {
        Application.Quit();
    }
    
    void Update()
        {
        if ((Input.GetKeyDown(KeyCode.M)))
        {
            SceneManager.LoadScene("MainMenu");
        }

        if (SceneManager.GetActiveScene().name != "LevelSelect")
            {
            
                Destroy(this.gameObject);
            }
           
            //else
            //{
               // SceneManager.LoadScene(sceneName);
           // }
            }
        }

    
            
