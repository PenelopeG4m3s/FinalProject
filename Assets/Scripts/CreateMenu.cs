using UnityEngine;
using Thing;

public class CreateMenu : MonoBehaviour
{
    // values
    public GameObject menuManager;
    public GameObject menuPawn;
    public GameObject camFollow;

    public void CreateMenus( menuId currentMenu )
    {
        // Instantiate the menu manager
        GameObject menuManagerTemp;
        menuManagerTemp = Instantiate(menuManager, Vector3.zero, Quaternion.identity) as GameObject;

        // Instantiate the menu pawn
        GameObject menuPawnTemp;
        menuPawnTemp = Instantiate(menuPawn, Vector3.zero, Quaternion.identity) as GameObject;

        // Instantiate the cam Follow
        GameObject camFollowTemp;
        // Decide the position for the menu
        camFollowTemp = Instantiate(camFollow, new Vector3( 0.0f, 0.0f, 0.0f), Quaternion.identity) as GameObject;

        // Set the manager pawn value to the menu pawn
        menuManagerTemp.GetComponent<MenuManager>().menuPawn = menuPawnTemp.GetComponent<MenuPawn>();

        // Set the current menu variable of the menu pawn
        menuPawnTemp.GetComponent<MenuPawn>().menu = currentMenu;

        // Set the current select variable of the menu pawn
        menuPawnTemp.GetComponent<MenuPawn>().mySelectId = buttons.Null;

        // Play the set camera function
        gameObject.GetComponent<SetCamera>().SetCam( camFollow );
    }
}