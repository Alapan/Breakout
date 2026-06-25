using NUnit.Framework;

public class GameRulesTests
{
    [Test]
    public void GameScore_IncreaseByTen()
    {
        var gameRules = new GameRules();
        gameRules.AddScore(10);
        Assert.AreEqual(10, gameRules.Score);
    }


    [Test]
    public void GameLives_DecreaseByOne()
    {
        var gameRules = new GameRules();
        gameRules.LoseLife();
        Assert.AreEqual(2, gameRules.Lives);
    }

    [Test]
    public void GameLives_DoNotGoBelowZero()
    {
        var gameRules = new GameRules();
        int initialLives = gameRules.Lives;

        for (int i = 0; i < initialLives+1; i++)
        {
            gameRules.LoseLife();
        }
        Assert.AreEqual(0, gameRules.Lives);

    }
}
