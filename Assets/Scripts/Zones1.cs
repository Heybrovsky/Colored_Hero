using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zones1 : MonoBehaviour
{
    GameObject Player;

    //Assigning prefabs on editor    
    public bool isRedLand;
    public bool isGreenLand;
    public bool isBlueLand;


    public bool isColorRed;
    public bool isColorGreen;
    public bool isColorBlue;
    public float timeStart = 3;
    private void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
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
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            colorCheck();
        }
    }


    void colorCheck()
    {

        if (isRedLand && !isGreenLand && !isBlueLand)
        {

            if (Player.name == "red")
            {

                isColorRed = true;



            }
            else if (Player.name == "blue" || Player.name == "green")
            {
                Destroy(GameObject.FindWithTag("Player"));
                isColorRed = false;
            }
        }



        if (isGreenLand && !isRedLand && !isBlueLand)
        {

            if (Player.name == "green")
            {

                isColorRed = true;


            }
            else if (Player.name == "red" || Player.name == "blue")
            {
                Destroy(GameObject.FindWithTag("Player"));

                isColorGreen = false;
            }
        }


        if (isBlueLand && !isGreenLand && !isRedLand)

        {

            if (Player.name == "blue")
            {

                isColorBlue = true;


            }
            else if (Player.name == "red" || Player.name == "green")
            {
                Destroy(Player);
                isColorBlue = false;
            }
        }
    }
}
