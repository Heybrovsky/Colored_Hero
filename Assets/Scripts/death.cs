using UnityEngine;

public class death : MonoBehaviour
{
    GameObject Player;
    private void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("tRIGGERED");
        if (other.tag == "Player")
        {
            Destroy(Player);
        }

    }
    void OnTriggerEnter2D()
    {
        Debug.Log("tRIGGERE111");


    }

}
