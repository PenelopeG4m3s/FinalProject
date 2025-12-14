using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Thing;

public class UIManager : MonoBehaviour
{
    public GameObject player;
    public TMP_Text inventoryText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateInventory();
    }

    // Update inventory
    void UpdateInventory()
    {
        inventoryText.text = "Firewood: " + player.GetComponent<Pawn>().inventory[items.Firewood]+ " Bullets: " + player.GetComponent<Pawn>().inventory[items.Bullets] + " Matches: " + player.GetComponent<Pawn>().inventory[items.Matches];
    }
}
