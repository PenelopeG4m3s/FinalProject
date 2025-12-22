using UnityEngine;
using Thing;

public class ObjectHover : MonoBehaviour
{
    // Player
    public GameObject player;
    // Is Hovering
    public bool isHovering;

    void OnMouseOver()
    {
        // Set the players select value to this
        player.GetComponent<Pawn>().hoverOver = gameObject;
        isHovering = true;
    }

    void OnMouseExit()
    {
        // Set the players select value to nothing
        player.GetComponent<Pawn>().hoverOver = null;
        isHovering = false;
    }
}
