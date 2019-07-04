using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIorPlayer : MonoBehaviour
{
    private int currentState = 0;

    [SerializeField]
    private GameObject player;

    void Start()
    {
        currentState = PlayerPrefs.GetInt("CurrentControlState", 0);
        CheckControls();
    }

    private void Update()
    {
        PlayerPrefs.SetInt("CurrentControlState", currentState);
    }

    public void SwitchControls()
    {
        if(player.GetComponent<Move>().enabled == true)
        {
            currentState = 1;
            player.GetComponent<Move>().enabled = false;
            player.GetComponent<AIMove>().enabled = true;
        }
        else if(player.GetComponent<AIMove>().enabled == true)
        {
            currentState = 0;
            player.GetComponent<AIMove>().enabled = false;
            player.GetComponent<Move>().enabled = true;
        }
    }

    public void CheckControls()
    {
        if(currentState == 0)
        {
            player.GetComponent<AIMove>().enabled = false;
            player.GetComponent<Move>().enabled = true;
        }
        else if(currentState == 1)
        {
            player.GetComponent<Move>().enabled = false;
            player.GetComponent<AIMove>().enabled = true;
        }
    }

}
