using UnityEngine;

public class SpawnPointDeath : MonoBehaviour
{
    public GameObject targetToSpawn;
    public GameObject targetModelToSpawn;
    public Vector3 targetPointTowards;
    public float amountToSpawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Spawn();
    }

    // Instantiate the objects
    public void Spawn()
    {
        // Loop through the amount of enemies to spawn
        for ( int i = 0; i < (amountToSpawn); i++ )
        {
            // create a temp enemy
            GameObject targetTemp;
            // instantiate it
            targetTemp = Instantiate(targetToSpawn, transform.position, transform.rotation) as GameObject;
            // create a temp enemy
            GameObject targetModelTemp;
            // instantiate it
            targetModelTemp = Instantiate(targetModelToSpawn, transform.position, transform.rotation) as GameObject;
            // set the player variable of it
            targetTemp.GetComponent<ObjectHover>().player = null;
            // set the target move towards variable
            targetTemp.GetComponent<TargetMove>().pointTowards = targetPointTowards;
            // set the speed variable
            targetTemp.GetComponent<TargetMove>().speed = 1.0f;
            // set the target variable
            targetModelTemp.GetComponent<TargetFollow>().target = targetTemp;
        }
    }
}
