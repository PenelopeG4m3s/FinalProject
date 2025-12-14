using System.Collections.Generic;
using UnityEngine;
using Thing;

public class Pawn : MonoBehaviour
{
    // ID system for all states the player can be in
    public enum playerStateTypes {
        Standing,
        Moving,
        Aiming
    };
    // The current state of the player
    public playerStateTypes playerState;
    // The object currently being hovered over
    public GameObject hoverOver;
    // Inventory
    public Dictionary<items, int> inventory;
    // In Hand
    public items InHand;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Object currently being hovered over
        hoverOver = null;
        // Inventory
        inventory = new Dictionary<items, int>()
        {
            {items.Firewood, 0},
            {items.Bullets, 0},
            {items.Matches, 0}
        };
        playerState = playerStateTypes.Standing;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(inventory[items.Firewood]);
        Debug.Log(Input.mousePosition.x);
        Debug.Log(Screen.width);
    }

    // Standing
    #region

        // rotate camera left
        public void LookLeft()
        {
            transform.Rotate(0.0f, ( ( Input.mousePosition.x - (Screen.width/2) + Screen.width/10 ) * 1.25f ) / Screen.width * Time.deltaTime * 90, 0.0f);
        }

        // rotate camera right
        public void LookRight()
        {
            transform.Rotate(0.0f, ((( Input.mousePosition.x - (Screen.width/2) - Screen.width/10 ) * 1.25f ) / Screen.width ) * Time.deltaTime * 90, 0.0f);
            //transform.Rotate(0.0f, (( Input.mousePosition.x - 960 - 192 ) * 1.25f ) / 1920 * Time.deltaTime*90, 0.0f);
        }

        // rotate camera up and down
        public void LookVertical()
        {
            transform.rotation = Quaternion.Euler(((Input.mousePosition.y-(Screen.height/2))/Screen.height)*-10.0f, transform.rotation.eulerAngles.y, 0.0f);
            //transform.rotation = Quaternion.Euler(((Input.mousePosition.y-540)/1080)*-10.0f, transform.rotation.eulerAngles.y, 0.0f);
        }

        // destroy item and add it to the inventory
        public void ClickItem()
        {
            // Check to make sure that an object is being hovered over
            if (hoverOver != null){
                // TODO: Figure out how to add item to inventory
                inventory[hoverOver.GetComponent<ItemPickup>().ID] += (int)hoverOver.GetComponent<ItemPickup>().Amount;
                Debug.Log(inventory[hoverOver.GetComponent<ItemPickup>().ID]);
                Destroy(hoverOver);
                hoverOver = null;
            }
        }

    #endregion

    // Moving
    #region 

        public void MoveForward()
        {
            // TODO: Make the player move forward
        }

    #endregion

    // Aiming
    #region 
    public void UseItem()
    {
        // TODO: switch case the current item and go through all possible items to figure out what the player is doing
    }
    #endregion
}
