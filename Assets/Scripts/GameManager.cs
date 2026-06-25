using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    private GameRules gameRules;

    void Awake()
    {
        gameRules = new GameRules();
        scoreText.text = "Score: 0";
    }

    public void IncreaseScore(int points)
    {
        gameRules.AddScore(points);
        scoreText.text = "Score: " + gameRules.Score;
    }
}
