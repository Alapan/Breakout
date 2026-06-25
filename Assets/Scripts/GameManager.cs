using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI livesText;

    private GameRules gameRules;

    void Awake()
    {
        gameRules = new GameRules();
        scoreText.text = "Score: 0";
        livesText.text = "Lives left: 3";
    }

    public void IncreaseScore(int points)
    {
        gameRules.AddScore(points);
        scoreText.text = "Score: " + gameRules.Score;
    }

    public void DecreaseLives()
    {
        gameRules.LoseLife();
        livesText.text = "Lives text: " + gameRules.Lives;
    }
}
