using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Void : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {//if the collider is the character, boolean = u beat the level)
        if (collision.tag == "jumpy")
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
