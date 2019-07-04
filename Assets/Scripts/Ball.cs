using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;

    private int playerScore { get { return PlayerPrefs.GetInt("PlayerScore"); } set { PlayerPrefs.SetInt("PlayerScore", value); } }
    private int enemyScore { get { return PlayerPrefs.GetInt("EnemyScore"); } set { PlayerPrefs.SetInt("EnemyScore", value); } }

    private float[] randomPos = new float[] { -2f, -1f, 1f, 2f }; // used for ball impulse
    private float speedMultiplier;
    private float speed = 10;

    private Vector3 initialImpulse; // ball impulse at the beggining of the round
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speedMultiplier = 1;
        initialImpulse = new Vector2((randomPos[Random.Range(0, randomPos.Length)]), (randomPos[Random.Range(0, randomPos.Length)]));
        rb.AddForce(initialImpulse, ForceMode.Impulse);
    }

    void FixedUpdate()
    {   
        rb.velocity = rb.velocity.normalized * speed * speedMultiplier; // ball movement
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
            speedMultiplier += .1f; // increase ball speed to make the game more challenging
        }
    }
}
