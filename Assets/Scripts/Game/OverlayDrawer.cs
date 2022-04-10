using UnityEngine;
using TMPro;

public class OverlayDrawer : MonoBehaviour
{
    [SerializeField]private GameObject overlay;
    [SerializeField]private TextMeshProUGUI scoreText;
    [SerializeField]private PlayerScore playerScore;
    private int language;

    private void Start()
    {
        language = PlayerPrefs.GetInt("Language");
    }

    private void OnEnable()
    {
        GameEvents.GameOverAction += DrawOverlay;
    }

    private void OnDisable()
    {
        GameEvents.GameOverAction -= DrawOverlay;
    }

    private void DrawOverlay() 
    {
        SetScoreText();
        overlay.SetActive(true);
    }

    private void SetScoreText()
    {
        int score = playerScore.GetScore();
        switch(language)
        {
            case 0: scoreText.text = $"You scored {score}";
                break;
            case 1: scoreText.text = $"Вы набрали {score}";
                break;
            case 2: scoreText.text = $"Ви набрали {score}";
                break;
        }
    }
}
