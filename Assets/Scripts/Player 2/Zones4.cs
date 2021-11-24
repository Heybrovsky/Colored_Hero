using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zones4 : MonoBehaviour
{
    public GameObject Player2;
    public GameObject ball;

    public bool isRedLand2;
    public bool isGreenLand2;
    public bool isBlueLand2;


    public bool isColorRed2;
    public bool isColorGreen2;
    public bool isColorBlue2;

    private void Start()
    {
        Player2 = GameObject.FindWithTag("Player2");
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player2")
        {
            colorCheck2();
        }
    }
    void Update()
    {
        if (isRedLand2 == true)
        {
            this.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.05f);
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (isGreenLand2 == true)
        {
            this.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.05f);
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (isBlueLand2 == true)
        {
            this.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.05f);
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
    }

    void colorCheck2()
    {

        if (isRedLand2 && !isGreenLand2 && !isBlueLand2)
        {

            if (Player2.name == "red2")
            {

                Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), Player2.GetComponent<Collider2D>(), false);



            }
            else if (Player2.name == "blue2" || Player2.name == "green2")
            {
                Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), Player2.GetComponent<Collider2D>(), true);
            }
        }



        else if (isGreenLand2 && !isRedLand2 && !isBlueLand2)
        {

            if (Player2.name == "green2")
            {

                Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), Player2.GetComponent<Collider2D>(), true);


            }
            else if (Player2.name == "red2" || Player2.name == "blue2")
            {
                Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), Player2.GetComponent<Collider2D>(), false);
            }
        }


        else if (isBlueLand2 && !isGreenLand2 && !isRedLand2)

        {

            if (Player2.name == "blue2")
            {

                Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), Player2.GetComponent<Collider2D>(), true);


            }
            else if (Player2.name == "red2" || Player2.name == "green2")
            {
                Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), Player2.GetComponent<Collider2D>(), false);
            }
        }
        else if (!isRedLand2 && !isGreenLand2 && !isBlueLand2)
        {

            if (Player2.name == "red2" || Player2.name == "green2" || Player2.name == "blue2")
            {

                Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), Player2.GetComponent<Collider2D>(), false);



            }
        }
    }
}
