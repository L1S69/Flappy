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
	
	public static Action PlayButtonClickAction;
    public static void PlayButtonClick()
    {
        PlayButtonClickAction?.Invoke();
    }
	
	public static Action StoreButtonClickAction;
    public static void StoreButtonClick()
    {
        StoreButtonClickAction?.Invoke();
    }
	
	public static Action BackButtonClickAction;
    public static void BackButtonClick()
    {
        BackButtonClickAction?.Invoke();
    }
	
	public static Action LeftButtonClickAction;
    public static void LeftButtonClick()
    {
        LeftButtonClickAction?.Invoke();
    }
	
	public static Action RightButtonClickAction;
    public static void RightButtonClick()
    {
        RightButtonClickAction?.Invoke();
    }
	
	public static Action SelectButtonClickAction;
    public static void SelectButtonClick()
    {
        SelectButtonClickAction?.Invoke();
    }

    public static Action<int> MoneyAmountChangeAction;
    public static void MoneyAmountChange(int amount)
    {
        MoneyAmountChangeAction?.Invoke(amount);
    }

    public static Action AddMoneyButtonClickAction;
    public static void AddMoneyButtonClick()
    {
        AddMoneyButtonClickAction?.Invoke();
    }
}
