using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zones3 : MonoBehaviour
{
    public GameObject Player;
    public GameObject ball;


    public bool isRedLand;
    public bool isGreenLand;
    public bool isBlueLand;



    private void Start()
    {
    }

 
    
    void Update()
    {
        colorCheck();

        if (isRedLand == true)
        {
            this.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.05f);
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (isGreenLand == true)
        {
            this.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.05f);
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (isBlueLand == true)
        {
            this.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.05f);
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
    }
    void colorCheck()
    {

        if (isRedLand && !isGreenLand && !isBlueLand)
        {

            if (Player.name == "red")
            {

                Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), Player.GetComponent<Collider2D>(), false);



            }
            else if (Player.name == "blue" || Player.name == "green")
            {
                Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), Player.GetComponent<Collider2D>(), true);
            }
        }



        else if (isGreenLand && !isRedLand && !isBlueLand)
        {

            if (Player.name == "green")
            {

                Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), Player.GetComponent<Collider2D>(), false);


            }
            else if (Player.name == "red" || Player.name == "blue")
            {
                Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), Player.GetComponent<Collider2D>(), true);
            }
        }


        else if (isBlueLand && !isGreenLand && !isRedLand)

        {

            if (Player.name == "blue")
            {

                Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), Player.GetComponent<Collider2D>(), false);


            }
            else if (Player.name == "red" || Player.name == "green")
            {
                Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), Player.GetComponent<Collider2D>(), true);
            }
        }
        else if (!isRedLand && !isGreenLand && !isBlueLand)
        {

            if (Player.name == "red" || Player.name == "green" || Player.name == "blue")
            {

                Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), Player.GetComponent<Collider2D>(), false);



            }
        }
    }
}

