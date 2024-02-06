using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racket : MonoBehaviour
{
public float speed = 150.0f;
   
    void FixedUpdate()
    {
        float horizontalDirection = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D> ().velocity=Vector2.right*horizontalDirection*speed;
    }
}
