using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameEvents.ScreenClickAction();
    }
}
