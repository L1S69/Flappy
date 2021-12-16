using UnityEngine;

public class OverlayDrawer : MonoBehaviour
{
    [SerializeField]private GameObject overlay;

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
        overlay.SetActive(true);
    }
}
