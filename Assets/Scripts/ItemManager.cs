using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject itemFirewood;
    public GameObject itemBullet;
    public GameObject player;

    public List<Vector3> positionsFirewood = new List<Vector3>();
    public List<Vector3> positionsBullet = new List<Vector3>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Add all of the different positions for the Firewood objects
        positionsFirewood.Add(new Vector3(1.629f, 0.5f, -2.88f));

        // Add all of the different positions for the Bullet objects
        positionsBullet.Add(new Vector3(2.857f, 0.38f, -0.502f));

        // Spawn the items
        SpawnItems();
    }

    // Spawn Items
    public void SpawnItems()
    {
        // loop through all the positions and instantiate firewood
        for (int i = 0; i < positionsFirewood.Count; i++)
        {
            // TODO: Spawn the items in the different spots
            GameObject itemFirewoodTemp;
            itemFirewoodTemp = Instantiate(itemFirewood, positionsFirewood[i], Quaternion.identity) as GameObject;
        
            // Set firewood variables
            itemFirewoodTemp.GetComponent<ObjectHover>().player = player;
        }

        // loop through all the positions and instantiate bullets
        for (int i = 0; i < positionsBullet.Count; i++)
        {
            // TODO: Spawn the items in the different spots
            GameObject itemBulletTemp;
            itemBulletTemp = Instantiate(itemBullet, positionsBullet[i], Quaternion.identity) as GameObject;
        
            // Set firewood variables
            itemBulletTemp.GetComponent<ObjectHover>().player = player;
        }
    }
}