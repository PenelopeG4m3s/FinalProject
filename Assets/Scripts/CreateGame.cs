using System.Collections.Generic;
using UnityEngine;
using Thing;

public class CreateGame : MonoBehaviour
{
    public GameObject playerPawn;
    public GameObject playerController;
    public GameObject userInterface;
    public GameObject itemManager;
    public GameObject campfireHitbox;
    public GameObject campfireText;
    public GameObject campfireLight;
    public GameObject spawnManager;
    public GameObject spawnPoint;
    public GameObject apple;

    public List<Vector3> positionsSpawnPoint = new List<Vector3>();
    public List<Vector3> goalSpawnPoint = new List<Vector3>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Add all of the different positions for the spawn points
        positionsSpawnPoint.Add(new Vector3(-6.37f, 0.0f, -4.43f));
        positionsSpawnPoint.Add(new Vector3(-4.82f, 0.0f, 6.17f));
        positionsSpawnPoint.Add(new Vector3(-11.0f, 0.0f, 4.0f));
        positionsSpawnPoint.Add(new Vector3(3.29f, 0.0f, 8.05f));
        positionsSpawnPoint.Add(new Vector3(6.57f, 0.0f, -3.6f));
        positionsSpawnPoint.Add(new Vector3(7.36f, 0.0f, 6.85f));
        positionsSpawnPoint.Add(new Vector3(-4.5f, 0.0f, -7.4f));
        positionsSpawnPoint.Add(new Vector3(3.75f, 0.0f, -7f));

        // Addd all of the different goals for the spawn points
        goalSpawnPoint.Add(new Vector3( -8.38f, 0.0f, 5.15f ));
        goalSpawnPoint.Add(new Vector3( 3.81f, 0.0f, 5.07f ));
        goalSpawnPoint.Add(new Vector3( -7.68f, 0.0f, -6.57f ));
        goalSpawnPoint.Add(new Vector3( -6.57f, 0.0f, 9.54f ));
        goalSpawnPoint.Add(new Vector3( 5.78f, 0.0f, 5.54f ));
        goalSpawnPoint.Add(new Vector3( 7.36f, 0.0f, -3.87f ));
        goalSpawnPoint.Add(new Vector3( 6.5f, 0.0f, -6f ));
        goalSpawnPoint.Add(new Vector3( -4.2f, 0.0f, -6.5f ));
    }

    // Create all of the game objects
    public void CreateGames()
    {
        // Instantiate the player pawn
        GameObject playerPawnTemp;
        playerPawnTemp = Instantiate(playerPawn, new Vector3( 0.0f, 1.0f, 0.0f ), Quaternion.identity) as GameObject;

        // Set all the player pawn variables
        playerPawnTemp.GetComponent<Pawn>().playerState = playerStateTypes.Standing;


        // Instantiate the player controller
        GameObject playerControllerTemp;
        playerControllerTemp = Instantiate(playerController, new Vector3( 0.0f, 1.0f, 0.0f ), Quaternion.identity) as GameObject;

        // Set all the player controller variables
        playerControllerTemp.GetComponent<Controller>().pawn = playerPawnTemp.GetComponent<Pawn>();

        // Set the camera to the player
        gameObject.GetComponent<SetCamera>().SetCam(playerPawnTemp);


        // Instantiate the main UI
        GameObject userInterfaceTemp;
        userInterfaceTemp = Instantiate(userInterface, Vector3.zero, Quaternion.identity) as GameObject;

        // Set all the ui variables
        userInterfaceTemp.GetComponent<UIManager>().player = playerPawnTemp;


        // Instantiate the item manager
        GameObject itemManagerTemp;
        itemManagerTemp = Instantiate(itemManager, Vector3.zero, Quaternion.identity) as GameObject;

        // Set all the item manager variables
        itemManagerTemp.GetComponent<ItemManager>().player = playerPawnTemp;


        // Instantiate the campfire hitbox
        GameObject campfireHitboxTemp;
        campfireHitboxTemp = Instantiate(campfireHitbox, new Vector3( 1.75f, 0.05f, 1.75f ), Quaternion.identity) as GameObject;

        // Set the campfire hitbox variables
        campfireHitboxTemp.GetComponent<ObjectHover>().player = playerPawnTemp;


        // Instantiate the campfire text
        GameObject campfireTextTemp;
        campfireTextTemp = Instantiate(campfireText, new Vector3( 1.75f, 1.0f, 1.75f ), Quaternion.Euler(0,45,0)) as GameObject;

        // Set all the campfire text variables
        campfireTextTemp.GetComponent<CampfireText>().campfire = campfireHitboxTemp;


        // Instantiate the campfire light
        GameObject campfireLightTemp;
        campfireLightTemp = Instantiate(campfireLight, new Vector3( 1.75f, 0.56f, 1.83f ), Quaternion.identity) as GameObject;

        // Set all the campfire light variables
        campfireLightTemp.GetComponent<CampfireLight>().campfire = campfireHitboxTemp;


        // Instantiate the spawn manager
        GameObject spawnManagerTemp;
        spawnManagerTemp = Instantiate(spawnManager, Vector3.zero, Quaternion.identity) as GameObject;


        // Instantiate the spawn points
        for (int i = 0; i < positionsSpawnPoint.Count; i++)
        {
            // Spawn the items in the different spots
            GameObject spawnPointTemp;
            spawnPointTemp = Instantiate(spawnPoint, positionsSpawnPoint[i], Quaternion.identity) as GameObject;
        
            // Set all the spawn point variables
            spawnPointTemp.GetComponent<SpawnPoint>().player = playerPawnTemp;
            spawnPointTemp.GetComponent<SpawnPoint>().targetPointTowards = goalSpawnPoint[i];
        }
        

        // Instantiate the apple
        GameObject appleTemp;
        appleTemp = Instantiate(apple, new Vector3( 1.116f, 1.317f, 2.803f ), Quaternion.identity) as GameObject;
    
        // Set all the apple variables
        appleTemp.GetComponent<ObjectHover>().player = playerPawnTemp;
    }
}