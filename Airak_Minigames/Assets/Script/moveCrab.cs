using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCrab : MonoBehaviour
{
    public GameObject[] hole;
    public int index;
    public float speed = 1f;
    private Rigidbody rb;
    private Vector3 dir;
    private int newIndex;
    private bool arrived;
    // Start is called before the first frame update
    void Start()
    {
        hole = GameObject.FindGameObjectsWithTag("Hole");
        arrived = false;
        index = Random.Range(0, 9); ;
        newIndex = Random.Range(0, 9);
        while(newIndex == index)
        {
            newIndex = Random.Range(0, 9);
        }
        Vector3 pos = hole[index].transform.position;
        pos.y = 0.75f;
        dir = new Vector3(0, 0, 0);
        transform.position = pos;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (newIndex != index)
        {
            index = newIndex;
            dir = (hole[index].transform.position - transform.position).normalized;
            dir.y = 0;
            //Debug.Log(name + " " + dir);
        }
    }

    private void FixedUpdate()
    {
        if (arrived)
        {
            arrived = false;
            StartCoroutine(Timedelay());
        }

        else
        {
            movePlayer(dir);
        }
        
    }

    private void OnTriggerEnter(Collider target)
    {

        if(target.name.Equals("Hole " + (newIndex + 1)))
        {
            arrived = true;
            dir.x = 0;
            dir.y = 0;
            dir.z = 0;
        }
    }

    private void movePlayer(Vector3 dir)
    {
        rb.velocity = dir * speed / 2;
    }

    public void destroyCrab()
    {
        Destroy(gameObject);
    }

    IEnumerator Timedelay()
    {
        hole[newIndex].GetComponent<HoleScript>().addCrab(gameObject);
        yield return new WaitForSeconds(2);
        while(newIndex == index)
        {
            newIndex = Random.Range(0, 9);
        }
        hole[index].GetComponent<HoleScript>().removeCrab(gameObject);
        
    }
}
