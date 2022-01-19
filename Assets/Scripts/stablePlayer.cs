using UnityEngine;

public class stablePlayer : MonoBehaviour
{
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
