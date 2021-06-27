using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yay : MonoBehaviour
{
    Animator animator;
    float InputX;
    public float InputY;
    public float Crooch;
    public float Joomp;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("InputJump");
        }
        
        InputY = Input.GetAxis ("Vertical");
        animator.SetFloat("InputY", InputY);
        Crooch = Input.GetAxis("Crouch");
        animator.SetFloat("Crooch", Crooch);
        InputX = Input.GetAxis("Horizontal");
        animator.SetFloat("InputX", InputX);
        Joomp = Input.GetAxis("Jump");
        animator.SetFloat("Joomp", Joomp);


    }
}
