using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 100;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //rb.velocity = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0) * speed;
    }

    public void btnR()
    {
        rb.velocity = new Vector3(speed, 0, 0);
        Debug.Log("button R pressed");
    }

    public void btnL()
    {
        rb.velocity = new Vector3(-speed, 0, 0);
        Debug.Log("button L pressed");
    }

    public void noBtn()
    {
        rb.velocity = new Vector3(0, 0, 0);
        Debug.Log("button left!");
    }
}