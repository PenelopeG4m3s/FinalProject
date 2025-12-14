using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager gameManager;
    // ID system for all items the player can use
    public enum items {
        Firewood,
        Bullets,
        Matches
    }

    void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;
        } else
        {
            Destroy(gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
