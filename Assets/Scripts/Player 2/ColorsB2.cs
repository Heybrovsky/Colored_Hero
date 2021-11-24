using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorsB2 : MonoBehaviour

 

{

    public Color altColor = Color.black;
    public Renderer rend;

    //I do not know why you need this?
    void Example()
    {
        altColor.g = 0f;
        altColor.r = 0f;
        altColor.b = 0f;
        altColor.a = 0f;
    }

    void Start()
    {
        //Call Example to set all color values to zero.
        Example();
        //Get the renderer of the object so we can access the color
        rend = GetComponent<Renderer>();
        //Set the initial color (0f,0f,0f,0f)
        rend.material.color = altColor;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (altColor.g == 0f)
            {       
                altColor.g += 10f;
                rend.material.color = altColor;
            }
            else if (altColor.g <= 10f)
            {
                altColor.g = 0f;
                rend.material.color = altColor;
            }
        } 
        if (Input.GetKeyDown(KeyCode.R))
        {
            
                if (altColor.r == 0f)
            {
                altColor.r += 10f;
                rend.material.color = altColor;
            }
            else if (altColor.r <= 10f)
            {
                altColor.r = 0f;
                rend.material.color = altColor;
            }
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (altColor.b == 0f)
            {

                altColor.b += 10f;
                rend.material.color = altColor;
            }
            else if (altColor.b <= 10f)
            {
                altColor.b = 0f;
                rend.material.color = altColor;
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (altColor.a == 0f)
            {
                altColor.a += 10f;
                rend.material.color = altColor;
            }
            else if (altColor.a <= 10f)
            {
                altColor.a = 0f;
                rend.material.color = altColor;
            }
        }
    }
}

