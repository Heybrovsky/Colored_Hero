using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private bool facingRight;
    [SerializeField]
    private float movementSpeed;
    Rigidbody2D rb;
    public Animator animator;


    [Range(1, 100)]
    public float jumpVelocity;
    public float groundedSkin = 0.0f;
    public LayerMask mask;

    bool jumpRequest;
    bool grounded = true;
    public GameObject groundCheckObject;
    public bool canMultipleJump = false;
    private int jumpCounter = 0;
    public int maxJumps = 0;




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
        }
        else
        {
            singleJump();
        }

        if (grounded == true)
        {
            animator.SetBool("IsJumping", false);


        }
        else if (grounded == false)
        {
            animator.SetBool("IsJumping", true);
        }
    }

    void singleJump()
    {

        if (Input.GetButtonDown("Jump") && grounded)
        {

            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpVelocity, ForceMode2D.Impulse);

        }
    }

    void multipleJump()
    {
        if (Input.GetButtonDown("Jump"))
        {

            if (jumpCounter < maxJumps)
            {
                GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpVelocity, ForceMode2D.Impulse);
                jumpCounter++;
            }
        }

        if (grounded == true)
        {
            animator.SetBool("IsJumping", false);
            jumpCounter = 1;

        }

    }



    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");

        HandleMovement(horizontal);

        /*   Vector3 characterScale = transofrm.localScale;
           if(input.GetAxis("Horizontal") > 0)
           {
               characterScale.x = 10;
           }
           transform.localScale = characterScale;
           */
        Flip(horizontal);

    }

    void HandleMovement(float horizontal)
    {

        rb.velocity = new Vector2(horizontal * movementSpeed, rb.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(horizontal));
    }

    private void Flip(float horizontal)
    {
        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;

            theScale.x *= -1;

            transform.localScale = theScale;
        }
    }
}
