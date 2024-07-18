using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    public float didMove;
    public float didJump;

    public float jumpCap = 5;

    public void Move(float jumpForce, float runSpeed, Rigidbody2D player, float didMove, float didJump)
    {
        player.velocity = new Vector2(didMove * runSpeed, player.velocity.y);
        //player.velocity = new Vector3(didJump * jumpForce, player.velocity.x);
    }
}
