using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    Rigidbody rb;
    public Vector3 initialImpulse;
    public int playerScore { get { return PlayerPrefs.GetInt("PlayerScore"); } set { PlayerPrefs.SetInt("PlayerScore", value); } }
    public int enemyScore { get { return PlayerPrefs.GetInt("EnemyScore"); } set { PlayerPrefs.SetInt("EnemyScore", value); } }
    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(initialImpulse, ForceMode.Impulse);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void FixedUpdate()
    {
        rb.velocity = rb.velocity.normalized * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyScore"))
        {
            playerScore++; 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (collision.gameObject.CompareTag("PlayerScore"))
        {
            enemyScore++;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
