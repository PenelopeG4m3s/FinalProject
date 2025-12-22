using UnityEngine;
using Thing;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public float timerMax;
    public float timer; // in seconds

    void Awake()
    {
        // TODO: Create a list of all spawn points in the world
        GameObject[] spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");

        // Tell the spawn points to spawn
        foreach (GameObject spawnpoint in spawnPoints)
        {
            // Runs the Spawn() function for each object
            //spawnpoint.GetComponent<SpawnPoint>().Spawn();
            Debug.Log(spawnpoint);
        }

        Debug.Log(spawnPoints.Length);

        timer = timerMax;
    }

    // Update is called once per frame
    void Update()
    {
        TimerManage();
    }

    // Spawn the target
    void SpawnTarget()
    {
        // TODO: Create a list of all spawn points in the world
        GameObject[] spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");

        if (spawnPoints != null && spawnPoints[0].GetComponent<SpawnPoint>().player.GetComponent<Pawn>().playerState != playerStateTypes.Death)
        {
            // randomly pick one of the spawn points and make it spawn its thing
            int random = Random.Range(0,spawnPoints.Length);
            for ( int i = 0; i < (spawnPoints.Length); i++ )
            {
                // check if this spawn point is the one to be called;
                if (i == random)
                {
                    spawnPoints[i].GetComponent<SpawnPoint>().Spawn();
                }
            }
        }
    }

    // Run Timer
    public void TimerProgress()
    {
        // Make sure that the timer won't go below zero
        if ((timer - Time.deltaTime) > 0)
        {
            timer -= Time.deltaTime;
        } else {
            timer = 0;
        }
    }

    // End Timer
    public void TimerEnd()
    {
        //Debug.Log("timer broke");
        // Spawn the target
        SpawnTarget();
    }

    // Reset Timer
    public void TimerReset()
    {
        timer = timerMax;
    }

    // Manage Timer
    public void TimerManage()
    {
        // Check if the timer is greater than zero
        if (timer > 0)
        {
            TimerProgress();
        } else { // The timer is less than or equal to zero
            TimerEnd();
            TimerReset();
        }
    }
}
