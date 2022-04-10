using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Tube tube)) 
        {
            GameEvents.GameOverAction();
        }

        if (collision.TryGetComponent(out ScoreZone scoreZone))
        {
            GameEvents.AddScoreAction();
        }
    }
}
