using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    public AudioSource AudioSource_GrabBullet;
    public AudioSource AudioSource_GrabFirewood;
    public AudioSource AudioSource_FireBullet;
    public AudioSource AudioSource_FireEmpty;
    public AudioSource AudioSource_PlaceFirewood;
    public AudioClip GrabBulletSound;
    public AudioClip GrabFirewoodSound;
    public AudioClip FireBulletSound;
    public AudioClip FireEmptySound;
    public AudioClip PlaceFirewoodSound;

    // Collect Items
    #region

    public void GrabBullet()
    {
        AudioSource_GrabBullet.PlayOneShot(GrabBulletSound, 1.0F);
    }

    public void GrabFirewood()
    {
        AudioSource_GrabFirewood.PlayOneShot(GrabFirewoodSound, 1.0F);
    }

    #endregion

    // Use Item
    #region
    public void FireBullet()
    {
        AudioSource_FireBullet.PlayOneShot(FireBulletSound, 1.0F);
    }

    public void FireEmpty()
    {
        AudioSource_FireEmpty.PlayOneShot(FireEmptySound, 1.0F);
    }

    public void PlaceFirewood()
    {
        AudioSource_PlaceFirewood.PlayOneShot(PlaceFirewoodSound, 1.0F);
    }
    
    #endregion
}
