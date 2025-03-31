using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorTransports : MonoBehaviour
{
    private float speed = 5;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        
    }
        
}

