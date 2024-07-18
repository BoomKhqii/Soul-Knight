using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UIElements;

public class ShinobiWalking : MonoBehaviour
{
    public float runningSpeed = 5;
    public float jump = 15;
    public Rigidbody2D shinobi;
    public Transform playerShinobi;
    private Animator anim;

    void Start() { anim = GetComponent<Animator>(); }

    void Update()
    {
        // Auto Movement to the left
        //shinobi.velocity = Vector2.left * runningSpeed;
        //anim.SetBool("isRunning", true);

        // Teleport to the back of the map
        if(transform.position.x <= -8.068637)
            transform.position = new Vector3(8.16f, transform.position.y, transform.position.z);
    
    }
}
