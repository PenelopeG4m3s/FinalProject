using UnityEngine;

public class Click_Campfire : Click
{
    public override void Clicked()
    {
        gameObject.GetComponent<Campfire>().firewood += 1;
    }
}