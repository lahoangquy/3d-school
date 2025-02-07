using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UseItem : MonoBehaviour
{
    public Image Fill;

    public Text AmountText;
    public int Amount;

    public float FillEat=0.05f;
    
    void Update(){
        Amount = int.Parse(AmountText.text);
    }
    public void OnButtonClick(){
        if (Amount > 0){
            Debug.Log("eat well nigga!");
            Fill.fillAmount += FillEat;
            Amount -=1;
            AmountText.text = Amount.ToString();
        }else{
            Debug.Log("nigga u out of item!");
        }
    }
}
