using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    public bool trawa;
    GameObject Player;
    // Start is called before the first frame update
    private void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    void OnCollisionStay2D(Collision2D other)
    {
        trawa = true;

    }
    // Update is called once per frame
    void Update()
    {
    
    }

    void gettingSmashed()
    {
        Destroy(GameObject.FindWithTag("Player"));
    }
}
