using UnityEngine;

public class AppleAudio : MonoBehaviour
{
    public AudioClip impact;

    void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(impact, transform.position, 1.0f);
    }
}