using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 30; // decrease player's battery usage a little bit
    }
}
