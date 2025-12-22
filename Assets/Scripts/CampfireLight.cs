using UnityEngine;

public class CampfireLight : MonoBehaviour
{
    public GameObject campfire;
    Light myLight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myLight = gameObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(campfire.GetComponent<Campfire>().firewood);
        //Debug.Log(campfire.GetComponent<Campfire>().firewoodLimit);
        //Debug.Log(((float)(campfire.GetComponent<Campfire>().firewood))/((float)campfire.GetComponent<Campfire>().firewoodLimit));
        myLight.intensity = 3.0f * ( (((float)(campfire.GetComponent<Campfire>().firewood))/((float)campfire.GetComponent<Campfire>().firewoodLimit) * .9f ) + ( ((float)campfire.GetComponent<Campfire>().timer / 5.0f) / (float)campfire.GetComponent<Campfire>().firewoodLimit));
    }
}
