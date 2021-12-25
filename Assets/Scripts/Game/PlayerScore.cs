using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI highscoreText;
    [SerializeField] private TextMeshProUGUI moneyText;

    private int highscore;
    private int money;
    private int score;

    private void Start()
    {
        highscore = PlayerPrefs.GetInt("Highscore");
        money = PlayerPrefs.GetInt("Money");
        highscoreText.text = $"{highscore}";
        moneyText.text = $"{money}";
    }

    private void OnEnable()
    {
        GameEvents.AddScoreAction += AddScore;
        GameEvents.GameOverAction += OnGameOver;
    }

    private void OnDisable()
    {
        GameEvents.AddScoreAction -= AddScore;
        GameEvents.GameOverAction -= OnGameOver;
    }

    private void AddScore() 
    {
        score++;
        money++;
        scoreText.text = score.ToString();
        moneyText.text = $"{money}";
    }

    private void OnGameOver()
    {
        Save();
    }

    private void Save() 
    {
        if(score > highscore) PlayerPrefs.SetInt("Highscore", score);
        PlayerPrefs.SetInt("Money", money);
    }

    [ContextMenu("Reset")]
    private void ResetScores()
    {
        PlayerPrefs.DeleteAll();
    }
}
