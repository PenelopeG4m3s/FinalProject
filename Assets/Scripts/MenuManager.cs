using UnityEngine;
using Thing;

public class MenuManager : MonoBehaviour
{
    public MenuPawn menuPawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckInputs();
    }

    void CheckInputs()
    {
        // check to see if the player presses something and that it has a button selected
        if (Input.GetMouseButtonDown(0) && (menuPawn.mySelectId != buttons.Null))
        {
            // check which menu it currently is
            switch (menuPawn.menu)
            {
                // start menu
                case (menuId.Start):
                    StartButtons();
                break;

                // Main Menu
                case (menuId.Main):
                    MainButtons();
                break;

                // Settings Menu
                case (menuId.Settings):
                    SettingsButtons();
                break;

                // Credits Menu
                case (menuId.Credits):
                    CreditsButtons();
                break;

                // Game Over Menu
                case (menuId.GameOver):
                    GameOverButtons();
                break;

                // Win Menu
                case (menuId.Win):
                    WinButtons();
                break;
            }
        }
    }

    // all the functions for each menus set of buttons
    #region 

    // Start
    void StartButtons()
    {
        // switch through the different buttons
        switch (menuPawn.mySelectId)
        {
            // Back
            case (buttons.Back):
                Debug.Log("Button is being clicked");
                menuPawn.BackBtn();
            break;
        }
    }

    // Main
    void MainButtons()
    {
        Debug.Log(menuPawn.mySelectId);
        // switch through the different buttons
        switch (menuPawn.mySelectId)
        {
            // Start
            case (buttons.Start):
                menuPawn.StartBtn();
            break;
            // Settings
            case (buttons.Settings):
                menuPawn.SettingBtn();
            break;
            // Credits
            case (buttons.Credits):
                menuPawn.CreditsBtn();
            break;
            // Quit
            case (buttons.Quit):
                menuPawn.QuitBtn();
            break;
        }
    }

    // Settings
    void SettingsButtons()
    {
        // switch through the different buttons
        switch (menuPawn.mySelectId)
        {
            // Fullscreen
            case (buttons.Fullscreen):
                menuPawn.FullscreenBtn();
            break;
            // VSync
            case (buttons.VSync):
                menuPawn.VSyncBtn();
            break;
            // Back
            case (buttons.Back):
                menuPawn.BackBtn();
            break;
        }
    }

    // Credits
    void CreditsButtons()
    {
        // switch through the different buttons
        switch (menuPawn.mySelectId)
        {
            // Back
            case (buttons.Back):
                menuPawn.BackBtn();
            break;
        }
    }

    // Game Over
    void GameOverButtons()
    {
        // switch through the different buttons
        switch (menuPawn.mySelectId)
        {
            // Start
            case (buttons.Start):
                menuPawn.StartBtn();
            break;
            // Back
            case (buttons.Back):
                menuPawn.BackBtn();
            break;
            // Quit
            case (buttons.Quit):
                menuPawn.QuitBtn();
            break;
        }
    }

    // Win
    void WinButtons()
    {
        // switch through the different buttons
        switch (menuPawn.mySelectId)
        {
            // Start
            case (buttons.Start):
                menuPawn.StartBtn();
            break;
            // Back
            case (buttons.Back):
                menuPawn.BackBtn();
            break;
            // Quit
            case (buttons.Quit):
                menuPawn.QuitBtn();
            break;
        }
    }

    #endregion
}
