using System.Collections.Generic;
using UnityEngine;
using Thing;

public class Pawn : MonoBehaviour
{
    // The current state of the player
    public playerStateTypes playerState;
    // The object currently being hovered over
    public GameObject hoverOver;
    // Inventory
    public Dictionary<items, int> inventory;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Object currently being hovered over
        hoverOver = null;
        // Inventory
        inventory = new Dictionary<items, int>()
        {
            {items.Firewood, 0},
            {items.Bullets, 10},
        };
        playerState = playerStateTypes.Standing;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(inventory[items.Firewood]);
        //Debug.Log(Input.mousePosition.x);
        //Debug.Log(Screen.width);
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
                // Switch between all the different objects that it could be
                switch(hoverOver.tag)
                {
                    // If the player is picking up an item
                    case "Item":
                        switch(hoverOver.GetComponent<Click_Item>().ID){
                            // The player is grabbing firewood
                            case items.Firewood:
                                gameObject.GetComponent<PlayerAudio>().GrabFirewood();
                            break;
                            // The player is grabbing a bullet
                            case items.Bullets:
                                gameObject.GetComponent<PlayerAudio>().GrabBullet();
                            break;
                        }
                        hoverOver.GetComponent<Click>().Clicked();
                        inventory[hoverOver.GetComponent<Click_Item>().ID] += (int)hoverOver.GetComponent<Click_Item>().Amount;
                        hoverOver = null;
                    break;
                    // If the player is putting firewood down
                    case "Campfire":
                        if (inventory[items.Firewood] > 0 && ((hoverOver.GetComponent<Campfire>().firewood) < hoverOver.GetComponent<Campfire>().firewoodLimit))
                        {
                            gameObject.GetComponent<PlayerAudio>().PlaceFirewood();
                            hoverOver.GetComponent<Click>().Clicked();
                            inventory[items.Firewood] -= 1;
                        }
                    break;
                }
            }
        }

    #endregion

    // Aiming
    #region
        // rotate camera left slowly
        public void LookLeftSlow()
        {
            transform.Rotate(0.0f, ( ( Input.mousePosition.x - (Screen.width/2) + Screen.width/10 ) * 1.25f ) / Screen.width * Time.deltaTime * 45, 0.0f);
        }

        // rotate camera right slow
        public void LookRightSlow()
        {
            transform.Rotate(0.0f, ((( Input.mousePosition.x - (Screen.width/2) - Screen.width/10 ) * 1.25f ) / Screen.width ) * Time.deltaTime * 45, 0.0f);
        }

        public void UseItem()
        {
            // Check to make sure that theres enough bullets in the gun
            if (inventory[items.Bullets] > 0){
                // the bullet hits something
                if (hoverOver != null)
                {
                    switch(hoverOver.tag)
                    {
                        // If the player is shooting the deer
                        case "Target":
                            hoverOver.GetComponent<Click>().Clicked();
                            inventory[items.Bullets] -= 1;
                            gameObject.GetComponent<PlayerAudio>().FireBullet();
                        break;
                        // If the player is shooting the apple
                        case "Apple":
                            hoverOver.GetComponent<Click>().Clicked();
                            inventory[items.Bullets] -= 1;
                            gameObject.GetComponent<PlayerAudio>().FireBullet();
                        break;
                    }
                } else { // fires at nothing
                    inventory[items.Bullets] -= 1;
                    gameObject.GetComponent<PlayerAudio>().FireBullet();
                }
            } else {
                gameObject.GetComponent<PlayerAudio>().FireEmpty();
            }
        }
    #endregion
}
