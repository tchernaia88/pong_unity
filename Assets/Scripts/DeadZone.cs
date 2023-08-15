using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour
{

    public Text scorePlayerText;
    public Text scoreEnemyText;

    int scorePlayerQuantity;
    int scoreEnemyQuantity;

    public SceneChanger sceneChanger;

    private void OnTriggerEnter2D(Collider2D ball)
    {
        if (gameObject.tag == "Izquierdo")
        {
            scoreEnemyQuantity++;
            UpdateScoreLabel(scoreEnemyText, scoreEnemyQuantity);

        }
        else if (gameObject.CompareTag("Derecho"))
        {
            scorePlayerQuantity++;
            UpdateScoreLabel(scorePlayerText, scorePlayerQuantity);
        }

        ball.GetComponent<BallBehaviour>().gameStarted = false;
        CheckScore();
    }

    void CheckScore()
    {
        if (scorePlayerQuantity >= 3)
        {
            sceneChanger.ChangeSceneTo("WinScene");
        }
        else if (scoreEnemyQuantity >= 3)
        {
            sceneChanger.ChangeSceneTo("DeadScene");
        }
    }

    void UpdateScoreLabel(Text label, int score)
    {
        label.text = score.ToString();
    }
}
