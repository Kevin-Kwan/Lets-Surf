using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float minAxisOffsetDegrees = 10f;

    public float ballSpeed = 10f;
    public float xStartDir = 0.0f;
    public float yStartDir = 1.0f;

    public Rigidbody2D rb;
    private float minXOffset = 0f;
    private float minYOffset = 0f;



    // Update is called once per frame

    public AudioSource hitSound;
    public AudioClip collisionSound;
    void Start()
    {
        gameObject.tag = "ball";
        rb = gameObject.GetComponent<Rigidbody2D>();
        Vector2 ballVec = new Vector2(xStartDir, yStartDir) * ballSpeed;
        rb.velocity = ballVec;

        float minDeltaAngleInRad = (minAxisOffsetDegrees * Mathf.Deg2Rad);
        minXOffset = Mathf.Sin(minDeltaAngleInRad) * ballSpeed;
        minYOffset = minXOffset;

        hitSound = GetComponent<AudioSource>();
        collisionSound = hitSound.clip;
    }
    private void Update()
    { TweakVelocityIfNeeded();

        
    }
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        hitSound.PlayOneShot(collisionSound);
        if (collisionInfo.gameObject.name == "KillHitbox")
        {


            
            Destroy(gameObject);

           

        }



    }
    private void TweakVelocityIfNeeded()
    {
        float randDeltaX = 0f;
        float randDeltaY = 0f;
        bool pathAltered = false;
        //ask why tf the ball sometimes bounces up from wall when heading down, or bounces down when going up
        if (Mathf.Abs(rb.velocity.x) < minXOffset)
        {
            randDeltaX = Random.Range(0.5f, 3f);
            float sign = Mathf.Sign(Random.Range(-1f, 1f));
            randDeltaX *= sign;

            pathAltered = true;
        }
        if (Mathf.Abs(rb.velocity.y) < minYOffset)
        {
            randDeltaY = Random.Range(0.5f, 3f);
            float sign = Mathf.Sign(Random.Range(-1f, 1f));
            Debug.Log(sign);
            randDeltaY *= sign;

            pathAltered = true;
        }
        if (pathAltered)
        {
            Vector2 curDir = rb.velocity;

            Vector2 diffDir = new Vector2(randDeltaX, randDeltaY);

            Vector2 newDir = curDir + diffDir;

            newDir.Normalize();

            rb.velocity = newDir * ballSpeed;
        } }
        
    
}
