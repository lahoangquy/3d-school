using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.iOS;
using UnityEngine.UI;

public class BuyItem : MonoBehaviour
{
    public double ItemCost;
    public Text ItemCostText;
    public Text productNameText;

    public double Money;
    public Text MoneyText;
    private string moneystr;

    //player's inventory
    public int NumbersOfCoffe;
    public Text NumbersOfCoffeText;

    public int NumbersOfHuman;
    public Text NumbersOfHumanText;

    public int AmoutOfProduce2;

    
    void Start(){
        //ItemCost = Convert.ToInt32(ItemCostText.text.Replace("$",""));
        moneystr = MoneyText.text.Split(':')[1].Trim();;//Regex.Match(MoneyText.text, @"\d+").Value;
        Money = Convert.ToDouble(moneystr);
        print(Money);
    }

    void Update(){
        ItemCost = ChoseProduct.instance.totalCost;
        //ItemCost = ChooseProduct2.instance2.totalCost;
    }
    public void OnButtonClick(){
        Buying(ShopItem.Items.Coffe);
    }

    private void Buying(ShopItem.Items items){
        if (Money <= 0 && Money - ChoseProduct.instance.totalCost <= 0){
            Debug.Log("nigga u out of money");
            return;
        }
        if (productNameText.text == "Coffe"){
            Debug.Log("you bought " + productNameText.text + " With price" + ItemCost);
            Money -= ChoseProduct.instance.totalCost;
            MoneyText.text = "Available Fund: " + Money.ToString();
            if ((int.TryParse(ChoseProduct.instance.AmoutOfProduce.text,out AmoutOfProduce2))){
            NumbersOfCoffe += AmoutOfProduce2;
            }
            NumbersOfCoffeText.text = NumbersOfCoffe.ToString();
        }
        // else if (productNameText.text == "A Human?"){
        //     Debug.Log("you bought " + productNameText.text + " With price" + ItemCost);
        //     Money -= ChooseProduct2.instance2.totalCost;
        //     MoneyText.text = "Available Fund: " + Money.ToString();
        //     if ((int.TryParse(ChooseProduct2.instance2.AmoutOfProduce.text,out AmoutOfProduce2))){
        //     NumbersOfHuman += AmoutOfProduce2;
        //     }
        //     NumbersOfHumanText.text = NumbersOfHuman.ToString();
        // }
    }
}
