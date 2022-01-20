using UnityEngine;

public class stablePlayer : MonoBehaviour
{
    public GameObject player = GameObject.FindGameObjectWithTag("Player");


    void Update()
    {
        if(player.transform.parent != null ){

            Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(), player.GetComponent<Collider2D>(), false);
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            Debug.Log("works");
            other.transform.parent = this.transform;
        }
           
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("works2");
        if (other.tag == "Player")
        {
            Debug.Log("works3");
            other.transform.parent = null;
        }
    }
}
