using UnityEngine;

public class Apple : MonoBehaviour
{
    Rigidbody m_Rigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // The apple has been shot and begins its fall
    public void StartFall()
    {
        m_Rigidbody.useGravity = true;
        m_Rigidbody.AddForce(transform.forward*500);
        Debug.Log("TheAppleHasBeenShot");
        m_Rigidbody.linearDamping = 2;
    }
}