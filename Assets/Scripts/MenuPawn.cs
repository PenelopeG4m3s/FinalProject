using UnityEngine;
using Thing;

public class MenuPawn : MonoBehaviour
{
    // Id of whatever button is currently being selected
    public buttons mySelectId;
    // Id of the current menu
    public menuId menu;

    // Update is called once per frame
    void Update()
    {
        //mySelectId = buttons.Null;
        //Debug.Log(mySelectId);
    }

    // all the different buttons
    #region 
    
    // Start Button
    public void StartBtn()
    {
        GameManager.gameManager.StartGame();
    }

    // Settings
    public void SettingBtn()
    {
        menu = menuId.Settings;
        mySelectId = buttons.Null;
    }

    // Credits
    public void CreditsBtn()
    {
        menu = menuId.Credits;
        mySelectId = buttons.Null;
    }

    // Quit
    public void QuitBtn()
    {
        Application.Quit();
    }

    // Fullscreen
    public void FullscreenBtn()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }

    // Vsync
    public void VSyncBtn()
    {
        if ( QualitySettings.vSyncCount == 1 ){
            QualitySettings.vSyncCount = 2;
        }
        if (QualitySettings.vSyncCount == 0){
            QualitySettings.vSyncCount = 2;
        }
        if (QualitySettings.vSyncCount == 2){
            QualitySettings.vSyncCount = 0;
        }
    }

    // Back
    public void BackBtn()
    {
        menu = menuId.Main;
        mySelectId = buttons.Null;
    }
    #endregion
}
