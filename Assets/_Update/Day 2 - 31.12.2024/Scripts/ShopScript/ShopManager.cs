using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public static ShopManager instance;
    public double Money;
    public Text MoneyText;
    private string moneystr;
    void Start()
    {
        moneystr = MoneyText.text.Split(':')[1].Trim();;//Regex.Match(MoneyText.text, @"\d+").Value;
        Money = Convert.ToDouble(moneystr);
        print(Money);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
