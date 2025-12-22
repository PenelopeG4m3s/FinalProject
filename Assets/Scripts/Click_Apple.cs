using UnityEngine;

public class Click_Apple : Click
{
    public override void Clicked()
    {
        gameObject.GetComponent<Apple>().StartFall();
    }
}