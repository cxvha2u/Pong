using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    float[] randomPos = new float[] { -2f, -1f, 1f, 2f };
    Rigidbody rb;
    public Vector3 initialImpulse;

    public int playerScore { get { return PlayerPrefs.GetInt("PlayerScore"); } set { PlayerPrefs.SetInt("PlayerScore", value); } }
    public int enemyScore { get { return PlayerPrefs.GetInt("EnemyScore"); } set { PlayerPrefs.SetInt("EnemyScore", value); } }

    public float speedMultiplier = 1;
    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialImpulse = new Vector3((randomPos[Random.Range(0, randomPos.Length)]), (randomPos[Random.Range(0, randomPos.Length)]), 0);
        rb.AddForce(initialImpulse, ForceMode.Impulse);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Time.timeScale = 1f;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            Time.timeScale = 2f;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Time.timeScale = 4f;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            Time.timeScale = 8f;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Time.timeScale = 16f;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            Time.timeScale = 32f;
        }
    }

    void FixedUpdate()
    {   
        rb.velocity = rb.velocity.normalized * speed * speedMultiplier;
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
        if (collision.gameObject.CompareTag("Wall"))
        {
            speedMultiplier += .1f;
        }
    }
}
