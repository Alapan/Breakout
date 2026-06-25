public class GameRules
{
    private int score = 0;
    private int lives = 3;

    public int Score => score;
    public int Lives => lives;

    public void AddScore(int points)
    {
        score += points;
    }

    public void LoseLife()
    {
        if (lives > 0)
        {
            lives--;
        }
    }
}
