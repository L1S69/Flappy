using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody;
    [SerializeField] private float force;
    [SerializeField] private float maxSpeed;
    private void OnEnable()
    {
        GameEvents.ScreenClickAction += ThrowUp;
    }

    private void OnDisable()
    {
        GameEvents.ScreenClickAction -= ThrowUp;
    }

    private void ThrowUp() 
    {
        rigidbody.AddForce(transform.up * force, ForceMode2D.Impulse);
    }

    private void Update()
    {
        if (rigidbody.velocity.magnitude > maxSpeed) 
        {
            rigidbody.velocity = Vector2.ClampMagnitude(rigidbody.velocity, maxSpeed);
        }
    }
}
