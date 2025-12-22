using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerDeath : MonoBehaviour
{
    public GameObject spawnPoint;

    public List<Vector3> positionsSpawnPoint = new List<Vector3>();

    void Start()
    {
        positionsSpawnPoint.Add(new Vector3(-10f, 0.0f, 0.0f));
        positionsSpawnPoint.Add(new Vector3(0.0f, 0.0f, -10.0f));
        positionsSpawnPoint.Add(new Vector3(10.0f, 0.0f, 0.0f));
        positionsSpawnPoint.Add(new Vector3(0.0f, 0.0f, 10.0f));
    }

    public void CreateSpawnPoints()
    {
        for ( int i = 0; i < (4); i++ )
        {
            // Create a spawn point
            GameObject spawnPointTemp;
            // instantiate it
            spawnPointTemp = Instantiate(spawnPoint, positionsSpawnPoint[i], transform.rotation) as GameObject;

            // Set the variable
            spawnPointTemp.GetComponent<SpawnPointDeath>().targetPointTowards = new Vector3( 0.0f, 0.0f, 0.0f );
            //spawnPointTemp.GetComponent<SpawnPointDeath>().player = gameObject.
        }
    }
}