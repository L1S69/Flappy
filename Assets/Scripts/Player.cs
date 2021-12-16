using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody;

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
