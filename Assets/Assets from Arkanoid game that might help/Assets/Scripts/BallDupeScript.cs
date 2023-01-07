using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDupeScript : MonoBehaviour
{
    public GameObject BallPrefab;
    GameObject balls;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {



        
        if (collisionInfo.gameObject.tag == "ball")
        {
            ScoreScript.scoreValue += 100;


            Destroy(this.gameObject);
            Instantiate(Resources.Load("ball"), transform.position, Quaternion.identity);
         
            

        }
        
    }
}
