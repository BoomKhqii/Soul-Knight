using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerMovements : MonoBehaviour
{
    public float speed = 5f, jump = 15f, horizontal;
    public Rigidbody2D samurai;
    public Transform playerSamurai;
    private Animation anim;

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        if(horizontal < 0f || horizontal > 0f)
        {
            Vector3 localScale = transform.localScale;
            localScale.x *= 1f;
            transform.localScale = localScale;
        }

        // restrict double jumping || done
        // jumping ani continuous
        if(Input.GetKeyDown(KeyCode.Space) && samurai.transform.position.y <= -2.4)
            samurai.velocity = Vector2.up * jump;
        else if(Input.GetKeyDown(KeyCode.W) && samurai.transform.position.y <= -2.4)
            samurai.velocity = Vector2.up * jump;
            
    }
    private void FixedUpdate()
    {
        samurai.velocity = new Vector2(horizontal * speed, samurai.velocity.y);
    }
}
