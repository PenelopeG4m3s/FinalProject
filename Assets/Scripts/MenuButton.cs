using UnityEngine;
using Thing;
using UnityEngine.UI;
using TMPro;

public class MenuButton : MonoBehaviour
{
    public GameObject menuPawn;
    public buttons myId;
    public menuId myMenu;
    public bool myCanSelect;
    public string myText;
    public float myXMax;
    public float myXMin;
    public float myYMax;
    public float myYMin;
    public bool isSelected;

    // Update is called once per frame
    void Update()
    {
        CheckMenu();
        if (myMenu == menuPawn.GetComponent<MenuPawn>().menu)
        {
            MouseSelect();
        }
        SetText();
        if (menuPawn.GetComponent<MenuPawn>().mySelectId == myId)
        {
            isSelected = true;
        } else {
            isSelected = false;
        }
    }

    void MouseSelect()
    {
        // Check if the mouse is within the boundaries
        if ((Input.mousePosition.x > myXMin) && (Input.mousePosition.x < myXMax) && (Input.mousePosition.y > myYMin) && (Input.mousePosition.y < myYMax))
        {
            menuPawn.GetComponent<MenuPawn>().mySelectId = myId;
        } else {
            if (menuPawn.GetComponent<MenuPawn>().mySelectId == myId)
            {
                menuPawn.GetComponent<MenuPawn>().mySelectId = buttons.Null;
            }
        }
    }

    void CheckMenu()
    {
        // check to make sure that our menu id is the same as the current menu
        if (myMenu == menuPawn.GetComponent<MenuPawn>().menu)
        {
            // TODO: make self functional
        } else {
            // TODO: make self not functional
        }
    }

    void SetText()
    {
        if (myMenu == menuPawn.GetComponent<MenuPawn>().menu)
        {
            gameObject.GetComponent<TMP_Text>().text = myText;
            if (myCanSelect)
            {
                string selectLeft = ( (menuPawn.GetComponent<MenuPawn>().mySelectId == myId) ? "> " : "  ");
                gameObject.GetComponent<TMP_Text>().text = selectLeft + myText;
            }
        } else {
            gameObject.GetComponent<TMP_Text>().text = "";
        }
    }
}
