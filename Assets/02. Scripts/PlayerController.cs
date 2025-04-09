using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 3.0f;
    Vector2 movement = new Vector2();
    Rigidbody2D rdbd2D;
    
    void Start()
    {
        rdbd2D = GetComponent<Rigidbody2D()>;
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }
}