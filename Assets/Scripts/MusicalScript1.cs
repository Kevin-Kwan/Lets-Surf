using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicalScript1 : MonoBehaviour
{
    public AudioSource bgm;
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "MainMenu"|| SceneManager.GetActiveScene().name == "LevelSelect")
        { 
        Destroy(this.gameObject);
    }

    }
}
