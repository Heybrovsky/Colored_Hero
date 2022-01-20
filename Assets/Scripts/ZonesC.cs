using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ZonesC : MonoBehaviour
{
    GameObject Player;


    public bool isRedLand;
    public bool isGreenLand;
    public bool isBlueLand;


    public bool isColorRed;
    public bool isColorGreen;
    public bool isColorBlue;

    private void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            colorCheck();
        }
    }
    void Update()
    {
                if(isRedLand==true){
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

                isColorRed = true;


            }
            else if (Player.name == "blue" || Player.name == "green" || Player.name == "Player")
            {
                SceneManager.LoadScene("Level1");
                isColorRed = false;
            }
        }


        if (isGreenLand && !isRedLand && !isBlueLand)
        {
            if (Player.name == "green")
            {

                isColorRed = true;


            }
            else if (Player.name == "red" || Player.name == "blue" || Player.name == "Player")
            {
                SceneManager.LoadScene("Level1");
                isColorGreen = false;
            }
        }

        if (isBlueLand && !isGreenLand && !isRedLand)

        {
            if (Player.name == "blue")
            {

                isColorBlue = true;


            }
            else if (Player.name == "red" || Player.name == "green" || Player.name == "Player")
            {
                SceneManager.LoadScene("Level1");
                isColorBlue = false;
            }
        }
    }
}