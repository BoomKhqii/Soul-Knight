using System.Collections;
using System.Collections.Generic;
using UnityEngine;
  
public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Blue"))
            gameObject.SetActive(false);
    }
}