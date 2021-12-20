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
            Cursor.lockState = CursorLockMode.None;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            
            Cursor.lockState = CursorLockMode.Locked;
        {
            itemShopUI.SetActive(false);
        }
    }
}
