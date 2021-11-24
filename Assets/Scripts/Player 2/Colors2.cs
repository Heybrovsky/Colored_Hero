using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colors2 : MonoBehaviour
{

    public GameObject Player2;

    void Update()
    {
        


        //Check if J key Down if it is change player name and color    
        if (Input.GetButtonDown("Fire1"))
        {

            Player2.name = "red2";
            gameObject.GetComponent<Renderer>().material.color = Color.red;

        }

        //Check if K key Down if it is change player name and color    
        if (Input.GetButtonDown("Fire2"))
        {
            Player2.name = "green2";
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }

        //Check if L key Down if it is change player name and color    
        if (Input.GetButtonDown("Fire3"))
        {
            Player2.name = "blue2";
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }

    }
}
