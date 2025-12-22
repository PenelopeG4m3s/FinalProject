using UnityEngine;

public class TargetMove : MonoBehaviour
{
    public float speed;
    public Vector3 pointTowards;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Set rotation
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, pointTowards-transform.position, 360.0f, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDirection);
    }

    // Update is called once per frame
    void Update()
    {
        // check if the target has made it to the spot
        if (transform.position == pointTowards)
        {
            Debug.Log("Position"+transform.position);
            Debug.Log("Point Towards"+pointTowards);
            Debug.Log("The transform position is equal to the pointtowards");
            EndTarget();
        } else {
            MoveForward();
        }
    }

    // Move forward
    public void MoveForward()
    {
        //transform.position = transform.position + ( transform.forward * speed * Time.deltaTime );
        transform.position = Vector3.MoveTowards(transform.position, pointTowards, speed * Time.deltaTime);
    }

    // Check to see if the target has made it
    public void EndTarget()
    {
        Debug.Log("Target has reached the destination");
        Destroy(gameObject);
    }
}
