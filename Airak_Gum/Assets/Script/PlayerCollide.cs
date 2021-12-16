using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollide : MonoBehaviour
{

    private HoleScript focusHole;

    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            focusHole.collectCrab();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hole")
        {
            focusHole = other.GetComponent<HoleScript>();
            other.GetComponent<Renderer>().material.color = new Color(130f/255f,219f/255f,84f/255f,152f/255f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Hole")
        {
            other.GetComponent<Renderer>().material.color = new Color(255f/255f,153f/255f,0,152f/255f);
        }
    }
}
