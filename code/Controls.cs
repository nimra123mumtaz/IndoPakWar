using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    static Animator anim;
    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
        bool f;
        if(Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger("isJumping");
            
        
        }
        if(Input.GetButton("Fire3"))
        {
            anim.SetBool("isProne", true);

        }

        if (Input.GetButton("B"))

        {
            anim.SetBool("isProne", false);
        }
        if (Input.GetButton("Fire1")) 
        {
            anim.SetBool("isSitting", true);

        }
       

        if (translation !=0)
        {
           
            anim.SetBool("isWalking", true);
            anim.SetBool("isProne", false);
            anim.SetBool("isSitting", false);
            anim.SetBool("isMovingProne", false);

        }
        else
        {
            anim.SetBool("isWalking", false);
           


        }
    }
}
