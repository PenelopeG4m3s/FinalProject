using UnityEngine;

public class RifleRotation : MonoBehaviour
{
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Do all of the math calculations to find the coordinate to look at
        #region
        Vector2 coordinates = new Vector2( 
            ( ( Input.mousePosition.x - (Screen.width/2) ) / (Screen.width/2)),
            ( ( ( Input.mousePosition.y - (Screen.height/2) ) / (Screen.height/2)) * (float)0.5625 )
        );
        //Debug.Log("X: "+coordinates.x+"\nY: "+coordinates.y);
        //Debug.Log(Input.mousePosition.y);
        //Debug.Log(( ( ( Input.mousePosition.y - (Screen.height/2) ) / Screen.height/2) * 0.5625 ));
        //Debug.Log("Y: "+coordinates.y);
        float P = Mathf.Sqrt((coordinates.x*coordinates.x)+(coordinates.y*coordinates.y));
	    float C = Mathf.Atan(P);
        float PI = (float)3.141593;
        float latitude = -90 + Mathf.Asin((Mathf.Cos(C)*Mathf.Sin((player.transform.rotation.x*PI)/(float)180.0))+((coordinates.y*Mathf.Sin(C)*Mathf.Cos((player.transform.rotation.x*PI)/(float)180.0))/P));
        float longitude = Mathf.Atan((coordinates.x*Mathf.Sin(C))/((P*Mathf.Cos((player.transform.rotation.x*PI)/(float)180.0)*Mathf.Cos(C))-(coordinates.y*Mathf.Sin((player.transform.rotation.x*PI)/(float)180.0)*Mathf.Sin(C))));
        //Debug.Log("Longitude: "+((180.0f*longitude)/PI)+"\nLatitude: "+((180.0f*latitude)/PI));
        Vector3 look = new Vector3(
            (2 * Mathf.Cos(longitude) * Mathf.Sin(latitude)),
            //0.0f,
            //(2 * Mathf.Sin(longitude) * Mathf.Sin(latitude)),
            (2 * Mathf.Cos(latitude)),
            //0.0f
            (2 * Mathf.Sin(longitude) * Mathf.Sin(latitude))
        );
        gameObject.transform.position = look;
        #endregion
        // Set 3D vector that has a position of where exactly the mouse is looking
        // use the look towards function thing to have it look towards it
    }
}
