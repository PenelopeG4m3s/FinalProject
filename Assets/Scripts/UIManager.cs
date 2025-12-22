using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Thing;

public class UIManager : MonoBehaviour
{
    public GameObject player;
    public TMP_Text inventoryText;
    public TMP_Text timerText;
    public TMP_Text scoreText;
    public TMP_Text roundText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateInventory();
        //UpdateTimer();
        UpdateScore();
        UpdateRound();
    }

    // Update Inventory
    void UpdateInventory()
    {
        inventoryText.text = "Fuel: " + player.GetComponent<Pawn>().inventory[items.Firewood]+ " Bullets: " + player.GetComponent<Pawn>().inventory[items.Bullets];
    }

    // Update Timer
    void UpdateTimer()
    {
        //timerText.text = "Time Remaining: " + GameManager.gameManager.timer + " sec";
    }

    // Update Score
    void UpdateScore()
    {
        //string scoreThing = (GameManager.gameManager.score).ToString();
        //int scoreLength = scoreThing.Length; 
        scoreText.text = "Score: " + "0000".Substring(0,4-((GameManager.gameManager.score).ToString()).Length) + GameManager.gameManager.score;
    }

    // Update round
    void UpdateRound()
    {
        if (GameManager.gameManager.round == 0)
        {
            roundText.text = "12 AM";
        } else {
            roundText.text = (((GameManager.gameManager.round).ToString()).Split(char.Parse(".")))[0] + " AM";
        }
    }
}
