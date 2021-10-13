using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
     void OnCollisionEnter2D()
    {
        Debug.Log("KAka radKA");
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Cross tha object Square");
    }
}
