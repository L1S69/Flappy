using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody;
    [SerializeField] private SpriteRenderer player;
    [SerializeField] private SkinsData skinsData;

    private void Start()
    {
        player.sprite = skinsData.Skins[PlayerPrefs.GetInt("ChoosedSkin")];
    }

    private void OnEnable()
    {
        GameEvents.GameOverAction += OnGameOver;
    }

    private void OnDisable()
    {
        GameEvents.GameOverAction -= OnGameOver;
    }

    private void OnGameOver() 
    {
        rigidbody.simulated = false;
    }
}
