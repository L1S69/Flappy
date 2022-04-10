using UnityEngine;
using UnityEngine.EventSystems;

public class SelectButton : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        GameEvents.SelectButtonClickAction();
    }
}