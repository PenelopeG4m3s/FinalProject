using UnityEngine;

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
            case(Pawn.playerStateTypes.Standing):
                CheckStandingInputs();
            break;
            // Player is moving
            case(Pawn.playerStateTypes.Moving):
                CheckMovingInputs();
            break;
            // Player is aiming
            case(Pawn.playerStateTypes.Aiming):
                CheckAimingInputs();
            break;
        }
    }

    void CheckStandingInputs()
    {
        // Move camera left
        if ( Input.mousePosition.x <= ( Screen.width/2 - Screen.width/10 ) )
        {
            pawn.LookLeft();
            //Debug.Log("Looking left");
        }

        // Mode camera right
        if ( Input.mousePosition.x >= ( Screen.width/2 + Screen.width/10 ) )
        {
            pawn.LookRight();
            //Debug.Log("Looking right");
        }

        // The mouse looks up and down
        pawn.LookVertical();

        // Click on an item to add to inventory
        if (Input.GetMouseButtonDown(0))
        {
            pawn.ClickItem();
        }

        //Debug.Log(Input.mousePosition);
        // Check if the player is about to use an item
        if (Input.GetMouseButton(1))
        {
            pawn.playerState = Pawn.playerStateTypes.Aiming;
            Debug.Log("Player is aiming");
        }
    }

    void CheckMovingInputs()
    {
        // Check whether the player is moving forward or not
        if (Input.GetMouseButtonDown(0))
        {
            pawn.MoveForward();
        } else {
            // Player state is no longer moving
            pawn.playerState = Pawn.playerStateTypes.Standing;
        }
    }

    void CheckAimingInputs()
    {
        // TODO: Add enum of all the items, switch case through the different types of items, and check what those items do when fired;
        if (Input.GetMouseButtonDown(0))
        {
            pawn.UseItem();
        }
        if (!Input.GetMouseButton(1))
        {
            pawn.playerState = Pawn.playerStateTypes.Standing;
        }
    }
}
