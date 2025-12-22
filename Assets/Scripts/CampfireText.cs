using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CampfireText : MonoBehaviour
{
    public GameObject campfire;
    public TMP_Text firewoodText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateFirewood();
    }

    void UpdateFirewood()
    {
        firewoodText.text = "Firewood: " + campfire.GetComponent<Campfire>().firewood + "\nTimer: " + campfire.GetComponent<Campfire>().timer;
    }
}