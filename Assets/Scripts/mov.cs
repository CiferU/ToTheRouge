using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{
    public float runSpeed = 2;
    public float jumpForce = 3;
    Rigidbody2D rb;
    public SpriteRenderer sr;
    public Animator animator;

    //Better jump
    public bool betterJump = false;
    public float fallMultiplier = 0.5f;
    public float lowJumpMultiplier = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(runSpeed, rb.velocity.y);
            sr.flipX = false;
            animator.SetBool("Walk", true);
        }
        else if (Input.GetKey(KeyCode.A)) 
        {
            rb.velocity = new Vector2(-runSpeed, rb.velocity.y);
            sr.flipX = true;
            animator.SetBool("Walk", true);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            animator.SetBool("Walk", false);
        }

        if (Input.GetKey(KeyCode.Space) && CheckGround.isGrounded) 
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        if (CheckGround.isGrounded == false) 
        {
            animator.SetBool("Jump", true);
            animator.SetBool("Walk", false);
        }

        if (CheckGround.isGrounded == true)
        {
            animator.SetBool("Jump", false);
        }

        if (betterJump) 
        {
            if (rb.velocity.y < 0) 
            {
                rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier) * Time.deltaTime;
            }

            if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space))
            {
                rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier) * Time.deltaTime;
            }
        }
    }
}
