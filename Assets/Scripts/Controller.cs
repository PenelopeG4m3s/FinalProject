using UnityEngine;
using Thing;

public class Controller : MonoBehaviour
{
    public Pawn pawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check which state the player is in
        switch(pawn.playerState)
        {
            // Player is standing still
            case(playerStateTypes.Standing):
                CheckStandingInputs();
            break;
            // Player is aiming
            case(playerStateTypes.Aiming):
                CheckAimingInputs();
            break;
            // Player is dying
            case(playerStateTypes.Death):
                CheckDeathInputs();
            break;
        }
    }

    void CheckStandingInputs()
    {
        // Move camera left
        if ( Input.mousePosition.x <= ( Screen.width/2 - Screen.width/10 ) )
        {
            pawn.LookLeft();
        }

        // Mode camera right
        if ( Input.mousePosition.x >= ( Screen.width/2 + Screen.width/10 ) )
        {
            pawn.LookRight();
        }

        // The mouse looks up and down
        pawn.LookVertical();

        // Click on an item to add to inventory
        if (Input.GetMouseButtonDown(0))
        {
            pawn.ClickItem();
        }

        // Check if the player is about to use an item
        if (Input.GetMouseButton(1))
        {
            pawn.playerState = playerStateTypes.Aiming;
        }
    }

    void CheckAimingInputs()
    {
        // Move camera left slow
        if ( Input.mousePosition.x <= ( Screen.width/2 - Screen.width/10 ) )
        {
            pawn.LookLeftSlow();
        }

        // Mode camera right slowly
        if ( Input.mousePosition.x >= ( Screen.width/2 + Screen.width/10 ) )
        {
            pawn.LookRightSlow();
        }

        // The mouse looks up and down
        pawn.LookVertical();

        // TODO: Add enum of all the items, switch case through the different types of items, and check what those items do when fired;
        if (Input.GetMouseButtonDown(0))
        {
            pawn.UseItem();
        }

        if (!Input.GetMouseButton(1))
        {
            pawn.playerState = playerStateTypes.Standing;
        }
    }

    void CheckDeathInputs()
    {
        // Move camera left
        if ( Input.mousePosition.x <= ( Screen.width/2 - Screen.width/10 ) )
        {
            pawn.LookLeft();
        }

        // Mode camera right
        if ( Input.mousePosition.x >= ( Screen.width/2 + Screen.width/10 ) )
        {
            pawn.LookRight();
        }

        // The mouse looks up and down
        pawn.LookVertical();
    }
}
