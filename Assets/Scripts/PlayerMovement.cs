using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float runSpeed = 2f;

    private float moveDirection = 0f;
    private Rigidbody2D rb;

    private void Start() 
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    private void OnMove(InputValue value)
    {
        moveDirection = value.Get<float>();
    }

    private void Update() 
    {
        rb.velocity = new Vector2(
            runSpeed * moveDirection,
            rb.velocity.y
        );
    }

}