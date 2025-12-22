using UnityEngine;
using Thing;

public class Click_Item : Click
{
    // Item ID
    public items ID;
    // Item Amount
    public float Amount;

    public override void Clicked()
    {
        Destroy(gameObject);
    }
}