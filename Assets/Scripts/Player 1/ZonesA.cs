using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonesA : MonoBehaviour
{
    public bool isRedLand;
    public bool isGreenLand;
    public bool isBlueLand;


    public GameObject Player;
    public GameObject ball;


    public float timeStart = 6;
    // Start is called before the first frame update

    void Start()
    {




        //Player = GameObject.FindWithTag("Player");
    }





    void Update()
    {
        colorCheck();
        timeStart -= Time.deltaTime;
        if (timeStart <= 6)
        {
            this.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.05f);
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            isRedLand = true;
            isGreenLand = false;
            isBlueLand = false;
        }
        if (timeStart <= 5)
        {

            this.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0f);
            isGreenLand = false;
            isRedLand = false;
            isBlueLand = false;
        }
        if (timeStart <= 4)
        {
            this.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.05f);
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
            isBlueLand = true;
            isGreenLand = false;
            isRedLand = false;
        }
        if (timeStart <= 3)
        {

            this.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0f);
            isGreenLand = false;
            isRedLand = false;
            isBlueLand = false;

        }
        if (timeStart <= 2)
        {
            this.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.05f);
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            isGreenLand = true;
            isRedLand = false;
            isBlueLand = false;
        }
        if (timeStart <= 1)
        {

            this.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0f);
            isGreenLand = false;
            isRedLand = false;
            isBlueLand = false;
        }
        if (timeStart <= 0)
        {

            timeStart = 6;
        }


    }

    void colorCheck()
    {

        if (isRedLand && !isGreenLand && !isBlueLand)
        {

            if (Player.name == "red")
            {

                Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), Player.GetComponent<Collider2D>(), true);



            }
            else if (Player.name == "blue" || Player.name == "green")
            {
                Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), Player.GetComponent<Collider2D>(), false);
            }
        }



        else if (isGreenLand && !isRedLand && !isBlueLand)
        {

            if (Player.name == "green")
            {

                Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), Player.GetComponent<Collider2D>(), true);


            }
            else if (Player.name == "red" || Player.name == "blue")
            {
                Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), Player.GetComponent<Collider2D>(), false);
            }
        }


        else if (isBlueLand && !isGreenLand && !isRedLand)

        {

            if (Player.name == "blue")
            {

                Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), Player.GetComponent<Collider2D>(), true);


            }
            else if (Player.name == "red" || Player.name == "green")
            {
                Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), Player.GetComponent<Collider2D>(), false);
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









