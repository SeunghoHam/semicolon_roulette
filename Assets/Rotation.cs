using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{   
    float rotationSpeed = 0f;
    public float Deceleration = 0.96f;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rotationSpeed = 10f;
        }
        gameObject.transform.Rotate(0,0,rotationSpeed);
        rotationSpeed *= Deceleration;
    }
}