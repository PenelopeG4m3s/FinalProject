using UnityEngine;
using Thing;

public class GameManager : MonoBehaviour
{

    public static GameManager gameManager;
    public string gameState; // can only be "Menu" or "Game"
    public float timer;
    public int score;
    public int round;
    public int hasWon;

    void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;
        } else
        {
            Destroy(gameObject);
        }

        timer = 0;
        score = 0;
        round = 1;

        hasWon = PlayerPrefs.GetInt("HasWon", 0);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartMenu(menuId.Start);
    }

    // Update is called once per frame
    void Update()
    {
        // check what state the game is in
        switch (gameState)
        {
            case "Menu":
                
            break;
            case "Game":
                gameObject.GetComponent<RoundTimer>().ManageTimer();
                timer = gameObject.GetComponent<RoundTimer>().timer;
                if (round == 6)
                {
                    Win();
                }
            break;
        }
    }

    // Start the death
    public void StartDeath()
    {
        // Destroy UI
        GameObject[] userInterfacesActive = GameObject.FindGameObjectsWithTag("UserInterface");
        foreach ( GameObject userInterfaceActive in userInterfacesActive )
        {
            Destroy(userInterfaceActive);
        }

        // Destroy spawn manager
        GameObject[] spawnManagersActive = GameObject.FindGameObjectsWithTag("SpawnManager");
        foreach ( GameObject spawnManagerActive in spawnManagersActive )
        {
            Destroy(spawnManagerActive);
        }

        // Destroy spawn points
        GameObject[] spawnPointsActive = GameObject.FindGameObjectsWithTag("SpawnPoint");
        foreach ( GameObject spawnPointActive in spawnPointsActive )
        {
            Destroy(spawnPointActive);
        }

        // Destroy Deer
        GameObject[] targetsActive = GameObject.FindGameObjectsWithTag("Target");
        foreach ( GameObject targetActive in targetsActive )
        {
            Destroy(targetActive);
        }

        // Set the player to death
        GameObject[] player = GameObject.FindGameObjectsWithTag("PlayerPawn");
        player[0].GetComponent<Pawn>().playerState = playerStateTypes.Death;

        // Create the spawn points
        gameObject.GetComponent<SpawnManagerDeath>().CreateSpawnPoints();
    }

    // Start the game
    public void StartGame()
    {
        round = 0;
        score = 0;
        gameObject.GetComponent<RoundTimer>().timer = gameObject.GetComponent<RoundTimer>().timerMax;
        gameObject.GetComponent<CreateGame>().CreateGames();
        gameState = "Game";

        // Destroy all the objects left over in the menu
        DestroyMenu();
    }

    // Start the menu
    public void StartMenu( menuId currentMenu)
    {
        // Destroy any leftover menus
        DestroyMenu();

        gameObject.GetComponent<CreateMenu>().CreateMenus(currentMenu);
        gameState = "Menu";

        // Destroy all the objects left over in the game
        DestroyGame();
    }

    public void DestroyGame()
    {
        // TODO: Destroy all the different objects created in the CreateGame function
        
        // Destroy player pawn
        GameObject[] playerPawnsActive = GameObject.FindGameObjectsWithTag("PlayerPawn");
        foreach ( GameObject playerPawnActive in playerPawnsActive )
        {
            Destroy(playerPawnActive);
        }

        // Destroy player controller
        GameObject[] playerControllersActive = GameObject.FindGameObjectsWithTag("PlayerController");
        foreach ( GameObject playerControllerActive in playerControllersActive )
        {
            Destroy(playerControllerActive);
        }

        // Destroy UI
        GameObject[] userInterfacesActive = GameObject.FindGameObjectsWithTag("UserInterface");
        foreach ( GameObject userInterfaceActive in userInterfacesActive )
        {
            Destroy(userInterfaceActive);
        }

        // Destroy item manager
        GameObject[] itemManagersActive = GameObject.FindGameObjectsWithTag("ItemManager");
        foreach ( GameObject itemManagerActive in itemManagersActive )
        {
            Destroy(itemManagerActive);
        }

        // Destroy campfire
        GameObject[] campfiresActive = GameObject.FindGameObjectsWithTag("Campfire");
        foreach ( GameObject campfireActive in campfiresActive )
        {
            Destroy(campfireActive);
        }

        // Destroy campfire light
        GameObject[] campfireLightsActive = GameObject.FindGameObjectsWithTag("CampfireLight");
        foreach ( GameObject campfireLightActive in campfireLightsActive )
        {
            Destroy(campfireLightActive);
        }

        // Destroy campfire text
        GameObject[] campfireTextsActive = GameObject.FindGameObjectsWithTag("CampfireText");
        foreach ( GameObject campfireTextActive in campfireTextsActive )
        {
            Destroy(campfireTextActive);
        }

        // Destroy spawn manager
        GameObject[] spawnManagersActive = GameObject.FindGameObjectsWithTag("SpawnManager");
        foreach ( GameObject spawnManagerActive in spawnManagersActive )
        {
            Destroy(spawnManagerActive);
        }

        // Destroy spawn points
        GameObject[] spawnPointsActive = GameObject.FindGameObjectsWithTag("SpawnPoint");
        foreach ( GameObject spawnPointActive in spawnPointsActive )
        {
            Destroy(spawnPointActive);
        }

        // Destroy spawn point death
        GameObject[] spawnPointDeathsActive = GameObject.FindGameObjectsWithTag("SpawnPointDeath");
        foreach ( GameObject spawnPointDeathActive in spawnPointDeathsActive )
        {
            Destroy(spawnPointDeathActive);
        }

        // Destroy Deer
        GameObject[] targetsActive = GameObject.FindGameObjectsWithTag("Target");
        foreach ( GameObject targetActive in targetsActive )
        {
            Destroy(targetActive);
        }

        // Destroy Items
        GameObject[] itemsActive = GameObject.FindGameObjectsWithTag("Item");
        foreach ( GameObject itemActive in itemsActive )
        {
            Destroy(itemActive);
        }

        // Destroy Apple
        GameObject[] applesActive = GameObject.FindGameObjectsWithTag("Apple");
        foreach ( GameObject appleActive in applesActive )
        {
            Destroy(appleActive);
        }
    }

    public void DestroyMenu()
    {
        // Destroy the menu manager
        GameObject[] menuManagersActive = GameObject.FindGameObjectsWithTag("MenuManager");
        foreach ( GameObject menuManagerActive in menuManagersActive )
        {
            Destroy(menuManagerActive);
        }

        // Destroy the menu pawn
        GameObject[] menuPawnsActive = GameObject.FindGameObjectsWithTag("MenuPawn");
        foreach ( GameObject menuPawnActive in menuPawnsActive )
        {
            Destroy(menuPawnActive);
        }

        // Destroy the cam follow
        GameObject[] cameraFollowsActive = GameObject.FindGameObjectsWithTag("CameraFollow");
        foreach ( GameObject cameraFollowActive in cameraFollowsActive )
        {
            Destroy(cameraFollowActive);
        }
    }

    // Game Over
    public void GameOver()
    {
        StartMenu(menuId.GameOver);
    }

    // Win
    public void Win()
    {
        StartMenu(menuId.Win);
        PlayerPrefs.SetInt("HasWon", 1);
    }
}