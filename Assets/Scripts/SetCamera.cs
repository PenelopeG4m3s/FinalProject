using UnityEngine;

public class SetCamera : MonoBehaviour
{
    // Set camera to the object
    public void SetCam( GameObject theObject)
    {
        // Find the camera object
        GameObject[] cameraActive = GameObject.FindGameObjectsWithTag("MainCamera");
        // Set the value of the player to theObject
        cameraActive[0].GetComponent<Cams>().player = theObject;
    }
}
