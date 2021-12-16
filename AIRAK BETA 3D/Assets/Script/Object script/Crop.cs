using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crop : MonoBehaviour,ICanGrow
{
    Transform crop;
    float timeBetweenGrowth = 1.5f;
    int growCounter = 0  ;
    
    void Start()
    {
        crop = this.GetComponent<Transform>();
        InvokeRepeating("Grow", timeBetweenGrowth, timeBetweenGrowth);
    }

    public void Grow()
    {
        if (growCounter < 7)
        {
            crop.position += new Vector3(0, 0.1f, 0);
            growCounter++;
        }
    }

    
}
