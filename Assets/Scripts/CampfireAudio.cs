using UnityEngine;

public class CampfireAudio : MonoBehaviour
{
    public AudioSource audioSource;

    // Update is called once per frame
    void Update()
    {
        audioSource.pitch = Random.Range(.8f,1.0f);
        audioSource.volume = ( (float)gameObject.GetComponent<Campfire>().firewood / (float)gameObject.GetComponent<Campfire>().firewoodLimit ) + ( ( gameObject.GetComponent<Campfire>().timer / 5.0f ) / gameObject.GetComponent<Campfire>().firewoodLimit);
    }
}
