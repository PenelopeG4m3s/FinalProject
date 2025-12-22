using UnityEngine;

public class Cams : MonoBehaviour
{
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        // set position
        transform.position = player.transform.position;
        // set rotation
        transform.rotation = Quaternion.Euler(player.transform.rotation.eulerAngles.x, player.transform.rotation.eulerAngles.y, player.transform.rotation.eulerAngles.z);
    }
}
