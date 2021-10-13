using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeReference]float speed = 0.01f;
    [SerializeField]float moveSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmaunt = Input.GetAxis("Horizontal") * speed*Time.deltaTime;
        float moveAmaunt = Input.GetAxis("Vertical") * moveSpeed*Time.deltaTime;
        transform.Rotate(0, 0,- steerAmaunt);
        transform.Translate(0,moveAmaunt,0);
    }
}

