using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    private int money;

    private void Start()
    {
        money = PlayerPrefs.GetInt("Money");
        GameEvents.MoneyAmountChangeAction(money);
    }

    private void OnEnable()
    {
        GameEvents.AddMoneyButtonClickAction += AddMoney;
    }

    private void OnDisable()
    {
        GameEvents.AddMoneyButtonClickAction -= AddMoney;
    }

    public bool SpendMoney(int amount)
    {
        if (money >= amount) 
        {
            money -= amount;
            PlayerPrefs.SetInt("Money", money);
            GameEvents.MoneyAmountChangeAction(money);
            return true;
        }
        else return false;
    }

    private void AddMoney() 
    {
        money += 100;
        PlayerPrefs.SetInt("Money", money);
        GameEvents.MoneyAmountChangeAction(money);
    }
}
