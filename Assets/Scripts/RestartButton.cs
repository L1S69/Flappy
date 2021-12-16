using UnityEngine;
using UnityEngine.EventSystems;

public class RestartButton : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        GameEvents.RestartAction();
    }
}
