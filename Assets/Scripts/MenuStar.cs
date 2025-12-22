using UnityEngine;
using Thing;
using UnityEngine.UI;
using TMPro;

public class MenuStar : MonoBehaviour
{
    public Image star;
    public menuId myMenu;

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<MenuPawn>().menu == myMenu)
        {
            SetAlpha((bool)(GameManager.gameManager.hasWon == 1));
        } else {
            SetAlpha(false);
        }
    }

    void SetAlpha( bool value)
    {
        var tempColor = star.color;
        tempColor.a = (int)( value ? 1 : 0 );
        star.color = tempColor;
    }
}