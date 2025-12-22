using UnityEngine;

public class Click_Target : Click
{
    public override void Clicked()
    {
        Destroy(gameObject);
        GameManager.gameManager.score += 100;
    }
}