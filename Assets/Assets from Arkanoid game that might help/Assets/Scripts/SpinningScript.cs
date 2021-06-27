using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpinningScript : MonoBehaviour
{
    
    public AudioSource hit;
    public float degrees;
    public AudioClip hitSound;
    private void Start()
    {
        hitSound = hit.clip;
        
    }
    private void FixedUpdate()
    {
        transform.Rotate(0, 0, degrees * Time.deltaTime);


    }
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {//add sound when hit
        ScoreScript.scoreValue += 50;
        hit.PlayOneShot(hitSound);
        

    }

}
