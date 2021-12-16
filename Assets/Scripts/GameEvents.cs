using System;

public static class GameEvents
{
    public static Action ScreenClickAction;
    public static void ScreenClick() 
    {
        ScreenClickAction?.Invoke();
    }

    public static Action GameOverAction;
    public static void GameOver()
    {
        GameOverAction?.Invoke();
    }

    public static Action AddScoreAction;
    public static void AddScore()
    {
        AddScoreAction?.Invoke();
    }

    public static Action RestartAction;
    public static void Restart()
    {
        RestartAction?.Invoke();
    }
}
