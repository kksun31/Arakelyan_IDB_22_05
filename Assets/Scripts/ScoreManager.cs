using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    //public Text scoreText; // ссылка на компонент Text. Как их связать? До этого же нормально работало

    private int score;

    private void Start()
    {
        score = 0;
        UpdateScoreText();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "OtherObject")
        {
            DecreaseScore();
        }
    }

    private void DecreaseScore()
    {
        score--;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        Debug.Log(score);
        //scoreText.text = "Score: " + score.ToString();
    }
}