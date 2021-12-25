using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI moneyText;
    private void OnEnable()
    {
        GameEvents.MoneyAmountChangeAction += ShowMoneyAmount;
    }

    private void OnDisable()
    {
        GameEvents.MoneyAmountChangeAction -= ShowMoneyAmount;
    }

    private void ShowMoneyAmount(int amount) 
    {
        moneyText.text = $"{amount}";
    }
}
