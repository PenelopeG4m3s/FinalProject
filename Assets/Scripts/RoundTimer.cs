using UnityEngine;

public class RoundTimer : MonoBehaviour
{
    public float timerMax;
    public float timer;

    public void ManageTimer()
    {
        // timer decrease
        if (timer > 0)
        {
            DecreaseTimer();
        } else {
            ResetTimer();
        }
    }

    public void DecreaseTimer()
    {
        // Make sure that it's greater than 0
        if ((timer - Time.deltaTime) > 0)
        {
            timer -= Time.deltaTime;
        } else {
            timer = 0;
        }
    }

    public void ResetTimer()
    {
        timer = timerMax;
        GameManager.gameManager.round += 1;
    }
}
