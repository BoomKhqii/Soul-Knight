using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : PlayerController
{

    float horizontalMove = 0f;
    public float runSpeed = 10;
    public float jumpForce = 10;
    public Rigidbody2D player;

    private void Update()
    {
        didMove = (Input.GetAxisRaw("Horizontal"));
        didJump = (Input.GetAxisRaw("Vertical"));
        
        // Spacebar register
        /*
        if (Input.GetKeyDown(KeyCode.Space))
            didJump = 1;
        else
            didJump = 0;

        Debug.Log(didJump);
        */
    }

    private void FixedUpdate()
    {
        Move(jumpForce, runSpeed, player, didMove, didJump);
        
    }
}
