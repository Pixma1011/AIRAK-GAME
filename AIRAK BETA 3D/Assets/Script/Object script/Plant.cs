using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    Inventory inventory;
    public GameObject crop;
    Transform farmland;
    // Start is called before the first frame update
    void Start()
    {
        inventory = gameObject.GetComponent<Inventory>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "WateredFarmland" && inventory.seed>0) {
            farmland = other.GetComponent<Transform>();
            Instantiate(crop, farmland.position, Quaternion.identity);
            inventory.useSeed(1);
            Debug.Log("Planted");
            other.tag = "PlantedFarmLand";
        }
    }
}
