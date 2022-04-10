using UnityEngine;
using UnityEngine.EventSystems;

public class RightButton : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        GameEvents.RightButtonClickAction();
    }
}