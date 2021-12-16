using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 50f;
    public Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = 0;
        float z = Input.GetAxis("Vertical");
        movement = new Vector3(x, y, z);
    }

    private void FixedUpdate()
    {
        movePlayer(movement);
    }

    private void movePlayer(Vector3 direction)
    {
        //rb.AddForce(direction * speed);
        rb.velocity = direction * speed;
    }
}
