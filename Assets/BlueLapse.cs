using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class BlueLapse : MonoBehaviour
{
    public Transform player;
    //public Transform blue;
    Rigidbody2D playerBody;
    public Rigidbody2D blue;
    public float speed;
    public float range;
    public float output;
    public float distanceToPlayer;
    Vector2 pullForce;
    void Start()
    {
        playerBody = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.G))
        {
            gameObject.SetActive(true);
            //blue.position = transform.position + new Vector3(3-2, 0, 0);
            blue.velocity = Vector2.right * speed;
        }
                    distanceToPlayer = Vector2.Distance(player.position, transform.position);
            if (distanceToPlayer <= range)
            {
                pullForce = (transform.position - player.position).normalized / distanceToPlayer * output;
                playerBody.AddForce(pullForce, ForceMode2D.Force);
                Debug.Log("pulling");
            }
            else if (distanceToPlayer <= 6)
            {
                Debug.Log("stay");
            }
            /*
        // -7.26
        // other.gameObject.CompareTag("Blue")
        if(transform.position.x >= 8.6)
            //Destroy(blue); // disable
            gameObject.SetActive(false);
            */
    }
}
