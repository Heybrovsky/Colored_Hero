using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public GameObject Player;
    public float dashCooldown = 1f; //How long the player has to wait before they can dash again

    private float lastDash = 0f; //Amount of time since we last dashed

    public float MaxDashSpeed = 5f;

    public float dashSpeed = 500;

    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Player = GameObject.FindWithTag("Player");
    }
    void Update()
    {
        checkDash();
    }

    private void checkDash()
    {
        lastDash += Time.deltaTime;

        if (lastDash >= dashCooldown && Input.GetKeyDown(KeyCode.F))
        {
            lastDash = 0f;
   
            float dashDirection = Input.GetAxis("Horizontal");
           
            GetComponent<Rigidbody2D>().velocity = new Vector2(MaxDashSpeed * dashDirection, GetComponent<Rigidbody2D>().velocity.y);
            rb.AddForce(transform.right * dashSpeed);
        }
    }
}
