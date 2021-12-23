using UnityEngine;
using UnityEngine.EventSystems;

public class AddMoneyButton : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        GameEvents.AddMoneyButtonClickAction();
    }
}