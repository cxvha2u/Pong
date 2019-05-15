using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 30;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //rb.velocity = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0) * speed;
    }

    public void btnR()
    {
        rb.velocity = new Vector3(1, 0, 0) * speed;
        Debug.Log("button R pressed");
    }

    public void btnL()
    {
        rb.velocity = new Vector3(-1, 0, 0) * speed;
        Debug.Log("button L pressed");
    }
}