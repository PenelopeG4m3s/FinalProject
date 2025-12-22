using UnityEngine;

public abstract class Click : MonoBehaviour
{
    public virtual void Clicked( )
    {
        Debug.Log("Click");
    }
}
