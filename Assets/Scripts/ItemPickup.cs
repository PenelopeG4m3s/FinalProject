using UnityEngine;
using Thing;

public class ItemPickup : MonoBehaviour
{
    // Item ID
    public items ID;
    // Item Amount
    public float Amount;
    // Player
    public GameObject player;
    // Is Hovering
    public bool isHovering;

    void OnMouseOver()
    {
        // Set the player
        player.GetComponent<Pawn>().hoverOver = gameObject;
        //Debug.Log("Mouse is hovering");
        isHovering = true;
        //Debug.Log(player.GetComponent<Pawn>().hoverOver.name);
    }

    void OnMouseExit()
    {
        //Debug.Log("Mouse exited " + gameObject.name);
        isHovering = false;
        player.GetComponent<Pawn>().hoverOver = null;
        //Debug.Log(player.GetComponent<Pawn>().hoverOver);
    }
}
