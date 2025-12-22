using UnityEngine;

public class TargetFollow : MonoBehaviour
{
    public GameObject target;

    void Start()
    {
        // Set rotation
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, target.GetComponent<TargetMove>().pointTowards-transform.position, 360.0f, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDirection);
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            transform.position = target.transform.position;
        } else {
            Destroy(gameObject);
        }
    }
}
