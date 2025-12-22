using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject player;
    public GameObject targetToSpawn;
    public GameObject targetModelToSpawn;
    public Vector3 targetPointTowards;
    public float amountToSpawn;
    //public float timerMax;
    //float timer; // in seconds

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //timer = timerMax;
    }

    // Update is called once per frame
    void Update()
    {
        //TimerManage();
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
            targetTemp.GetComponent<ObjectHover>().player = player;
            // set the target move towards variable
            targetTemp.GetComponent<TargetMove>().pointTowards = targetPointTowards;
            // set the speed variable
            //targetTemp.GetComponent<TargetMove>().speed = Random.Range( 0.0f, 2.0f );
            targetTemp.GetComponent<TargetMove>().speed = 1.0f;
            // set the target variable
            targetModelTemp.GetComponent<TargetFollow>().target = targetTemp;
        }
    }

    // Run Timer
    public void TimerProgress()
    {
        // Make sure that the timer won't go below zero
        //if ((timer - Time.deltaTime) > 0)
        //{
            //timer -= Time.deltaTime;
        //} else {
            //timer = 0;
        //}
    }

    // End Timer
    public void TimerEnd()
    {
        //Debug.Log("timer broke");
        // Spawn the target
        //Spawn();
    }

    // Reset Timer
    public void TimerReset()
    {
        //timer = timerMax;
    }

    // Manage Timer
    public void TimerManage()
    {
        // Check if the timer is greater than zero
        //if (timer > 0)
        //{
            //TimerProgress();
        //} else { // The timer is less than or equal to zero
            //TimerEnd();
            //TimerReset();
        //}
    }
}
