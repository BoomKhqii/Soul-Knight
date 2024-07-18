using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerMovements : MonoBehaviour
{
    public float walkingSpeed = 3, jump = 15;
    public Rigidbody2D samurai;
    public Transform playerSamurai;
    private Animation anim;

    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            samurai.velocity = Vector2.right * walkingSpeed;
            //anim.SetBool("isWalking", true);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            samurai.velocity = Vector2.left * walkingSpeed;
            //playerSamurai.transform.rotation = -180;
            //nim.
        }
        //else 
            //anim.SetBool("isWalking", false);
        
        // restrict double jumping || done
        // jumping ani continuous
        if(Input.GetKeyDown(KeyCode.Space) && samurai.transform.position.y <= -2.4)
            samurai.velocity = Vector2.up * jump;
        else if(Input.GetKeyDown(KeyCode.W) && samurai.transform.position.y <= -2.4)
            samurai.velocity = Vector2.up * jump;
            
    }
}
