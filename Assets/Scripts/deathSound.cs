using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathSound : MonoBehaviour
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

            this.GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);
        }
       
    }
}