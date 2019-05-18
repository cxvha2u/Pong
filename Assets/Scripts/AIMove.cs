using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMove : MonoBehaviour
{
    public int level = 1; //1 - easy, 2 - medium, 3 - hard
    public Transform ball;
    Vector3 newPos;

    [Range(0, 1)]
    public float skill;
    
    public void switchAI()
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
        newPos = transform.position;
        newPos.x = Mathf.Lerp(transform.position.x, ball.position.x, skill);
        transform.position = newPos;
        InvokeRepeating("switchAI", 1.0f, 1.0f); //wait before changing the skill again
    }
}
