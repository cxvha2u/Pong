using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private int currentState;

    Vector2 mousePos;
    Vector2 playerPos;

    private void Start()
    {
        mousePos = new Vector2(Screen.width/2, transform.position.y);
        playerPos = mousePos;
    }

    void FixedUpdate()
    {
        currentState = PlayerPrefs.GetInt("CurrentControlState", 0); // used for AI debugging - player can switch to AI

        //playerPos = transform.position; // 
        playerPos.x = Mathf.Lerp(transform.position.x, mousePos.x, .4f); //can't acc
        transform.position = playerPos;
    }

    private void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}