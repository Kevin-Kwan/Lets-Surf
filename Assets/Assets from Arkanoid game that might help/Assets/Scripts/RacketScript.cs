

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;


public class RacketScript : MonoBehaviour
{
    public float speed = 150f;
    //get number of bricks
    //when 0 u win
    public GameObject[] blocks;
    void Start()
    {
        blocks = GameObject.FindGameObjectsWithTag("brick");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void FixedUpdate()
    {
        blocks = GameObject.FindGameObjectsWithTag("brick");
        Debug.Log(blocks.Length);
        
        if (blocks.Length == 0)
        {
        }
            float h = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
    }
}
