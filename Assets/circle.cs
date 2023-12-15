using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle : MonoBehaviour
{

     void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("โอ๊ย"); 
    }

      void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("Hello Silachai Phonphai");
    }
}
