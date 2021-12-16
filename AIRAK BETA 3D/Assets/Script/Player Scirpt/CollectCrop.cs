using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCrop : MonoBehaviour,IHarvestable
{
    public Item item;
    public bool collectable = false;
    public Inventory inventory;
    
    
    
    private void OnTriggerEnter(Collider other)
    {
        item = other.GetComponent<Item>();
        collectable = true;
    }
  


    void Update()
    {
        Collect();
    }

   public void Collect()
    {
        if (collectable && Input.GetKeyDown(KeyCode.C))
        {
            Destroy(item.gameObject);
            inventory.addMoney(5);

        }
    }
}
