using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    private bool facingRight;
    [SerializeField]
    private float movementSpeed;
    Rigidbody2D rb;



    [Range(1, 10)]
    public float jumpVelocity;
    public float groundedSkin = 0.0f;
    public LayerMask mask;

    bool jumpRequest;
    bool grounded;
    public GameObject groundCheckObject;
    public bool canMultipleJump = false;
    private int jumpCounter = 0;
    public int maxJumps = 0;

    public bool freezeRotation;




    private void Start()
    {
        facingRight = true;
        rb = GetComponent<Rigidbody2D>();
        jumpCounter = 1;
    }

    private void Update()
    {


        RaycastHit2D hit01 = Physics2D.Raycast(
            groundCheckObject.transform.position,
            Vector2.down,
            groundedSkin,
            mask);
        grounded = (hit01.collider != null);

        if (canMultipleJump)
        {
            multipleJump();
        }else
        {
            singleJump();
        }
    }

    void singleJump(){

        if (Input.GetButtonDown("Jump2") && grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpVelocity, ForceMode2D.Impulse);
        }
    }

    void multipleJump()
    {
        if (Input.GetButtonDown("Jump2"))
        {
            if(jumpCounter< maxJumps)
            {
                GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpVelocity, ForceMode2D.Impulse);
                jumpCounter++;
            }
        }

        if (grounded)
        {
            jumpCounter = 1;
        }
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal2");

        HandleMovement(horizontal);

        //Flip(horizontal);

    }

    void HandleMovement(float horizontal2)
    {
        rb.velocity = new Vector2(horizontal2 * movementSpeed, rb.velocity.y);
    }

   /* private void Flip(float horizontal)
    {
        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;

            theScale.x *= -1;

            transform.localScale = theScale;
        }
    }*/
}
