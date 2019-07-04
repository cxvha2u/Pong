using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMove : MonoBehaviour
{
    [SerializeField]
    private int level = 1; //1 - easy, 2 - medium, 3 - hard
    
    private float skill;

    [SerializeField]
    private Transform ball;

    private Vector2 newPos;

    private void Start()
    {
        newPos = new Vector2(Screen.width / 2, transform.position.y);
        skill = Random.Range(0.05f, 0.15f);
    }

    public void SwitchLevel()
    {
        if(level == 1)
        {
            skill = Random.Range(0.05f, 0.15f);
            CancelInvoke();
        }
        else if (level == 2)
        {
            skill = Random.Range(0.15f, 0.35f);
            CancelInvoke();
        }
        else if (level == 3)
        {
            skill = Random.Range(0.35f, 0.55f);
            CancelInvoke();
        }
    }

    void FixedUpdate()
    {
        newPos.x = Mathf.Lerp(transform.position.x, ball.position.x, skill);
        transform.position = newPos;
        InvokeRepeating("SwitchLevel", 1.0f, 1.0f); //wait before changing the skill again
    }
}
