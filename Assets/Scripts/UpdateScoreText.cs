using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScoreText : MonoBehaviour
{
    [SerializeField]
    private Text playerScoreText;
    [SerializeField]
    private Text enemyScoreText;

    private void Update()
    {
        playerScoreText.text = PlayerPrefs.GetInt("PlayerScore").ToString();
        enemyScoreText.text = PlayerPrefs.GetInt("EnemyScore").ToString();
    }
}
