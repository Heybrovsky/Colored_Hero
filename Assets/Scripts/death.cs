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

        if (other.tag == "Player")
        {
            Destroy(Player);
        }

    }


}
