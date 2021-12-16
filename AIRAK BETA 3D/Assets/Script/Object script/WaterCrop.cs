using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCrop : MonoBehaviour
{
    public Material[] plotState;
    public Inventory inventory;
    Renderer plot;
    bool watered;

    private void Start()
    {
        plot = gameObject.GetComponent<Renderer>();
        plot.enabled = true;
        plot.sharedMaterial = plotState[0];
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        watered = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && inventory.getWater() > 0 && !watered)
        {
            plot.sharedMaterial = plotState[1];
            inventory.useWater(1);
            Debug.Log(inventory.getWater());
            watered = true;
            gameObject.tag = "WateredFarmland";
        }
        
    }
        
        
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
