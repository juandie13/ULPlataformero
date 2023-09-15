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
    private Animator animator;

    private void Start() 
    {
        rb = GetComponent<Rigidbody2D>();   
        animator = GetComponent<Animator>();
    }

    private void OnMove(InputValue value)
    {
        moveDirection = value.Get<float>();
    }

    private void Update() 
    {
        Run();
        FlipSprite();
    }

    private void Run()
    {
        if (moveDirection==0f)
        {
            animator.SetBool("IsRunning",false);
        }
        else
        {
            animator.SetBool("IsRunning",true);
        }
        rb.velocity = new Vector2(
            runSpeed * moveDirection,
            rb.velocity.y
        );
    }
    private void FlipSprite()
    {
        if(Mathf.Abs(rb.velocity.x) > Mathf.Epsilon)
        {
            transform.localScale = new Vector3(
                Mathf.Sign(rb.velocity.x),
                1f,
                1f
            );
        }
        
    }

}