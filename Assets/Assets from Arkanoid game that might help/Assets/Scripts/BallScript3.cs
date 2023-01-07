using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript3 : MonoBehaviour
{
    private Vector2 inDirection;
    public float multiplier = 0.1f;
    public float minspeed=0.8f;
    public float maxspeed=1.2f;
    public AudioSource hitSound;
    public AudioClip collisionSound;

    public void Start()
    {
        gameObject.tag = "ball";
        inDirection = new Vector2(Random.Range(-0.5f,0.5f), Random.Range(minspeed,maxspeed));
        hitSound = GetComponent<AudioSource>();
        collisionSound = hitSound.clip;
        
    }
    public void FixedUpdate()
    {
       
        transform.Translate(inDirection * multiplier, Space.World);
    }
    //Sent when an incoming collider of another object makes contact with this object's collider in 2d space (box and circle collider)
    public void OnCollisionEnter2D(Collision2D collision)
    {   //information about the 2d collision is stored in the parameter "collision" https://docs.unity3d.com/ScriptReference/Collision2D.html
        //Store the first point of contact between the two colliders in world space as vector 
        Vector2 contactPoint = collision.contacts[0].point;

        //The position property of a GameObject’s (ball's) Transform. Transform is used to store and manipulate the position, rotation and scale of the object.
        Vector2 ballLocation = transform.position; 

        //position stored in Vector2 ballLocation
        //normalize vector from subtracting contactPoint from ballLocation and store in vector inNormal (do this to determine the vector that is perpendicular to the surface of what is colliding with ball)
        Vector2 inNormal = (ballLocation - contactPoint).normalized;

        //Reflects a vector off the vector defined by a inNormal (perpendicular vector) and inDirection (direction of the ball coming into what's colliding with it)
        inDirection = Vector2.Reflect(inDirection, inNormal);

        //Plays the audioclip of a given AudioSource
        hitSound.PlayOneShot(collisionSound);

        //If the incoming GameObject involved in the collision is named "KillHitbox"
        if (collision.gameObject.name == "KillHitbox") 
        {
            ScoreScript.scoreValue -= 100;
            //destroy/remove the current object being the ball from the scene
            Destroy(gameObject); 
        }
        
    }
}