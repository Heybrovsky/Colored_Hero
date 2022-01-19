using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool facingRight;
    [SerializeField]
    private float movementSpeed;
    Rigidbody2D rb;
    public Animator animator;

    public ParticleSystem dust;

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

    public float dashCooldown = 1f; //How long the player has to wait before they can dash again

    private float lastDash = 0f; //Amount of time since we last dashed

    public float MaxDashSpeed = 5f;

    public float dashSpeed = 500;




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
            CreateDust();
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpVelocity, ForceMode2D.Impulse);

        }
    }

    void multipleJump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            
            if (jumpCounter < maxJumps)
            {
                CreateDust();
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


    void CreateDust()
    {
        dust.Play();
    }
    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        

        if(horizontal == 0)
        {
            Debug.Log("works");
           
        }
        else
        {
           
        }

        HandleMovement(horizontal);

        /*   Vector3 characterScale = transofrm.localScale;
           if(input.GetAxis("Horizontal") > 0)
           {
               characterScale.x = 10;
           }
           transform.localScale = characterScale;

           */
        Flip(horizontal);
        checkDash();

    }

    void HandleMovement(float horizontal)
    {
      
        rb.velocity = new Vector2(horizontal * movementSpeed, rb.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(horizontal));
        
    }

     void Flip(float horizontal)
    {
        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;

            theScale.x *= -1;

            transform.localScale = theScale;
            
            if(grounded == true)
            {
                CreateDust();
            }

        }
    }

    private void checkDash()
    {
        lastDash += Time.deltaTime;
        
        if (lastDash >= dashCooldown && Input.GetKeyDown(KeyCode.F))
        {
            lastDash = 0f;
            float dashDirection = Input.GetAxis("Horizontal");
            GetComponent<Rigidbody2D>().velocity = new Vector2(MaxDashSpeed * dashDirection, GetComponent<Rigidbody2D>().velocity.y);
         
            if (facingRight == false)
            {
                Debug.Log("left");
               
                rb.AddForce(transform.position += Vector3.left * dashSpeed);
            }else if (facingRight != false)
            {
                Debug.Log("Right");
               
                rb.AddForce(transform.position += Vector3.right * dashSpeed);
            }
            
        }
    }


}
