using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zones2 : MonoBehaviour
{
    GameObject Player2;

    //Assigning prefabs on editor    
    public bool isRedLand2;
    public bool isGreenLand2;
    public bool isBlueLand2;

    public bool isColorRed2;
    public bool isColorGreen2;
    public bool isColorBlue2;



    public float timeStart = 3;
    private void Start()
    {
        Player2 = GameObject.FindWithTag("Player2");
    }

    void Update()
    {
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
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player2")
        {
            colorCheck2();
        }
    }


    void colorCheck2()
    {

        if (isRedLand2 && !isGreenLand2 && !isBlueLand2)
        {
            if (Player2.name == "red2")
            {

                isColorRed2 = true;


            }
            else if (Player2.name == "blue2" || Player2.name == "green2")
            {
                Destroy(GameObject.FindWithTag("Player2"));
                isColorRed2 = false;
            }
        }


        if (isGreenLand2 && !isRedLand2 && !isBlueLand2)
        {
            if (Player2.name == "green2")
            {

                isColorRed2 = true;


            }
            else if (Player2.name == "red2" || Player2.name == "blue2")
            {
                Destroy(GameObject.FindWithTag("Player2"));
                isColorGreen2 = false;
            }
        }

        if (isBlueLand2 && !isGreenLand2 && !isRedLand2)

        {
            if (Player2.name == "blue2")
            {

                isColorBlue2 = true;


            }
            else if (Player2.name == "red2" || Player2.name == "green2")
            {
                Destroy(GameObject.FindWithTag("Player2"));
                isColorBlue2 = false;
            }
        }
    }
}
