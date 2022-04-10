using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    private int money;

    [SerializeField] private int reward;

    private void Start()
    {
        money = PlayerPrefs.GetInt("Money");
        GameEvents.MoneyAmountChangeAction(money);
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

    public void AddMoney() 
    {
        money += reward;
        PlayerPrefs.SetInt("Money", money);
        GameEvents.MoneyAmountChangeAction(money);
    }
}
