using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colors : MonoBehaviour
{

    public GameObject player;

    void Update()
    {
        


        
        if (Input.GetKeyDown(KeyCode.J))

        {

            player.name = "red";
            player.layer = 11;
            gameObject.GetComponent<Renderer>().material.color = Color.red;

        }

         
        if (Input.GetKeyDown(KeyCode.L))
        {
            player.name = "green";
            player.layer = 12;
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }

         
        if (Input.GetKeyDown(KeyCode.K))
        {
            player.name = "blue";
            player.layer = 13;
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }

    }
}
