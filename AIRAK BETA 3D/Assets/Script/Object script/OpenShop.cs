using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenShop : MonoBehaviour
{
    public GameObject itemShopUI;

    private void Start()
    {
      
        itemShopUI.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {

            itemShopUI.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            itemShopUI.SetActive(false);
        }
    }
}
