using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleScript : MonoBehaviour
{
    private ArrayList crabs = new ArrayList();
    public GameObject controller;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addCrab(GameObject crab)
    {
        crabs.Add(crab);
        //Debug.Log(name + " Add " + crab.name);
    }

    public void removeCrab(GameObject crab)
    {
        crabs.Remove(crab);
        //Debug.Log(name + " Remove " + crab.name);
    }

    public void collectCrab()
    {
        int lastCrab = crabs.Count;
        if (lastCrab != 0)
        {
            GameObject crab = crabs[lastCrab - 1] as GameObject;
            crabs.RemoveAt(lastCrab - 1);
            Debug.Log("Collect " + crab.name);
            crab.GetComponent<moveCrab>().destroyCrab();
            controller.GetComponent<Controller>().collectCrab();
        }
        else
        {
            Debug.Log("No crab here");
        }
        
    }
}
