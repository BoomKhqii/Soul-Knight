using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShinobiInteraction : MonoBehaviour
{
    public int health = 10;
    //private float dazedTime;
    //public float startDazeTime;
    private Animator anim;
    public BoxCollider2D playerHitbox;
    //public ShinobiWalking shinobi;
    void Start() 
    { 
        anim = GetComponent<Animator>(); 
        //shinobi = GameObject.FindGameObjectWithTag("Logic").GetComponent<ShinobiWalking>();
        
    }

    void Update()
    {
        if(health <=0)
        {
            anim.SetTrigger("dead");
            anim.SetBool("deaded", true);
        }
        /*
        if(dazedTime <= 0)
            shinobi.runningSpeed = 5;
        else {
            shinobi.runningSpeed = 0;
            dazedTime -= Time.deltaTime;
        }
        */
    }
    public void TakeDamage(int damage){
        //dazedTime = startDazeTime;
        health -= damage;
        anim.SetTrigger("tookDamage");
        Debug.Log("Damage taken");

    }

}

