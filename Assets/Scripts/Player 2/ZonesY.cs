using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonesY : MonoBehaviour
{
    public bool isRedLand2;
    public bool isGreenLand2;
    public bool isBlueLand2;


    public GameObject Player2;
    public GameObject ball;


    public float timeStart = 6;
    // Start is called before the first frame update

    void Start()
    {




        //Player = GameObject.FindWithTag("Player");
    }





    void Update()
    {
        colorCheck2();
        timeStart -= Time.deltaTime;
        if (timeStart <= 6)
        {
            this.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.05f);
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            isRedLand2 = true;
            isGreenLand2 = false;
            isBlueLand2 = false;
        }
        if (timeStart <= 5)
        {

            this.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0f);
            isGreenLand2 = false;
            isRedLand2 = false;
            isBlueLand2 = false;
        }
        if (timeStart <= 4)
        {
            this.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.05f);
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
            isBlueLand2 = true;
            isGreenLand2 = false;
            isRedLand2 = false;
        }
        if (timeStart <= 3)
        {

            this.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0f);
            isGreenLand2 = false;
            isRedLand2 = false;
            isBlueLand2 = false;

        }
        if (timeStart <= 2)
        {
            this.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.05f);
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            isGreenLand2 = true;
            isRedLand2 = false;
            isBlueLand2 = false;
        }
        if (timeStart <= 1)
        {

            this.GetComponent<SpriteRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0f);
            isGreenLand2 = false;
            isRedLand2 = false;
            isBlueLand2 = false;
        }
        if (timeStart <= 0)
        {

            timeStart = 6;
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

                Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), Player2.GetComponent<Collider2D>(), false);


            }
            else if (Player2.name == "red2" || Player2.name == "blue2")
            {
                Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), Player2.GetComponent<Collider2D>(), true);
            }
        }


        else if (isBlueLand2 && !isGreenLand2 && !isRedLand2)

        {

            if (Player2.name == "blue2")
            {

                Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), Player2.GetComponent<Collider2D>(), false);


            }
            else if (Player2.name == "red2" || Player2.name == "green2")
            {
                Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), Player2.GetComponent<Collider2D>(), true);
            }
        }
        else if (!isRedLand2 && !isGreenLand2 && !isBlueLand2)
        {

            if (Player2.name == "red2" || Player2.name == "green2" || Player2.name == "blue2")
            {

                Physics2D.IgnoreCollision(ball.GetComponent<Collider2D>(), Player2.GetComponent<Collider2D>(), true);



            }
        }
    }

}









