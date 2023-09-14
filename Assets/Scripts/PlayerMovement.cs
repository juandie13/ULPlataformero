using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField]
   private float runSpeed = 2f;
   private float moveDirection = 0f;
   private Rigidbody2D rb;

   private void Start() {
      moveDirection = value.Get<float>();
   }
   
   private void OnMove(InputValue value)
   {
      moveDirection = value.Get<float>();
   }
   
   private void Update() {
      rb.velocity = Vector2
      {
         runSpeed * moveDirection,
         rb.velocity.y
      };
   }
}
