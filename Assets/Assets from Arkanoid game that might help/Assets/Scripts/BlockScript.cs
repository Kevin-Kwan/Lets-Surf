using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BlockScript : MonoBehaviour
{
    public int lives=1;
    Sprite okaySprite;
    Sprite owSprite;
    public AudioSource hit;
    
    public AudioClip hitSound;
    private void Start()
    {
        hitSound = hit.clip;

    }
    private void FixedUpdate()
    {   
        if (lives == 0)
        {
            Destroy(gameObject);
        }

    }
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {//add sound when hit
        ScoreScript.scoreValue += 10;
        hit.PlayOneShot(hitSound);
        lives = lives - 1;
        Debug.Log(lives);
        
    }

}
