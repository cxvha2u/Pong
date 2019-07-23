using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWallsByScreenSize : MonoBehaviour
{
    [SerializeField]
    private GameObject wallLeft;
    [SerializeField]
    private GameObject wallRight;

    // Start is called before the first frame update
    void Start()
    {
        wallLeft.transform.position = new Vector3(-Screen.width, transform.position.y, transform.position.z);
        wallRight.transform.position = new Vector3(Screen.width, transform.position.y, transform.position.z);
        //wallLeft.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(-Screen.width, transform.position.y, transform.position.z));
        //wallRight.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, transform.position.y, transform.position.z));
    }
}
