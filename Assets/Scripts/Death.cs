using UnityEngine;

public class Death : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // make sure the deer collides with us
        if (other.tag == "Target")
        {
            GameManager.gameManager.GameOver();
        }
    }
}
