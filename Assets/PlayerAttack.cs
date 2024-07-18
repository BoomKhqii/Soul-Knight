using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float timeBetweenAttacks;
    public float startTimeBetweenAttacks;

    public Transform attackPos;
    public float attackRange;
    public LayerMask whatIsEnemies;
    public int damage = 10;


    void Update()
    {
        if(timeBetweenAttacks <= 0)
        {
            //left click
            if(Input.GetKey(KeyCode.R))
            {
                Debug.Log("attacked");
                    Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
                for(int i = 0; i < enemiesToDamage.Length; i++)
                    enemiesToDamage[i].GetComponent<ShinobiInteraction>().TakeDamage(damage);
            }
            timeBetweenAttacks = startTimeBetweenAttacks;
        } else { timeBetweenAttacks -= Time.deltaTime; }
    } 

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}
