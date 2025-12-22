using UnityEngine;

public class Campfire : MonoBehaviour
{
    public int firewoodAmount;
    public int firewoodLimit;
    public int firewood;
    public float timer;
    bool plays;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        firewood = firewoodAmount;
        timer = 5; // Five seconds
        plays = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (plays)
        {
            // if the timer is still going
            if (timer > 0){
                // There is firewood
                if (firewood > 0)
                {
                    DecreaseTimer();
                }
            } else { // if the timer has finished
                ResetTimer();
            }
        }
    }

    void DecreaseTimer()
    {
        // descrease the timer
        if ((timer - Time.deltaTime) > 0){
            timer -= Time.deltaTime;
        } else {
            timer = 0;
        }
    }

    void ResetTimer()
    {
        // check how much firewood is left
        if ( ( firewood - 1 ) > 0){
            firewood -= 1;
            timer = 5;
        } else {
            firewood = 0;
            timer = 0;
            GameManager.gameManager.StartDeath();
            plays = false;
        }
    }
}
