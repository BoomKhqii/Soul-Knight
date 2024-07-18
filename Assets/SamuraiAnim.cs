using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamuraiAnim : MonoBehaviour
{
    private Animator anim;
    public Transform Samurai;

    void Start() { anim = GetComponent<Animator>(); }

    void Update()
    {
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
            anim.SetBool("isWalking", true);
        else 
            anim.SetBool("isWalking", false);
        
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space))
            anim.SetBool("didJump", true);
        else 
            anim.SetBool("didJump", false);

        if(Input.GetKey(KeyCode.R))
            anim.SetBool("didLeftClick", true);
        else
            anim.SetBool("didLeftClick", false);

        Flip();
    }

    private void Flip()
    {
        if(Input.GetKey(KeyCode.D))
        {
            Vector3 localScale = transform.localScale;
            localScale.x = 3f;
            transform.localScale = localScale;
        }

        if(Input.GetKey(KeyCode.A))
        {
            Vector3 localScale = transform.localScale;
            localScale.x = -3f;
            transform.localScale = localScale;
        }
    }
}
