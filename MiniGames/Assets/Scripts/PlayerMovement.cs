using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 4f;
    public Rigidbody2D rb;

    public Animator animator;
    Vector2 movement;

    void Update()
    {
      //Input
      movement.x = Input.GetAxisRaw("Horizontal");
      movement.y = Input.GetAxisRaw("Vertical");
      if(animator != null){
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        //if player is moving left, flip sprite 180 for left running animation
        // if(movement.x < 0){
        //   // transform.Rotate(0f,180f,0f, Space.Self);
        //   transform.Rotate(0f,180f,0f, Space.World);
        //
        // }
        // else{
        //   transform.Rotate(0f,0f,0f, Space.Self);
        // }
        //sqrMagniturde is length of movement vector (speed)
        // this will always be positive when we move (square roots are positive)
        animator.SetFloat("Speed", movement.sqrMagnitude);
      }

    }

    //this is called many times per second however it is executed on a fixed time
    void FixedUpdate()
    {
      //fixedDeltaTime = elapsed time since this method was called last
      rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
