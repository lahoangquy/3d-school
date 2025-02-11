using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TuitionScript : MonoBehaviour
{
    public static TuitionScript Instance {get;private set;}
    public Transform Container;
    public Transform ItemTem;

    public void Awake(){
        if (Instance==null) {
            Instance =this;
        }
        ItemTem.gameObject.SetActive(false);
    }

    public void CreateTuition(Sprite Icon,String Name,int Cost,float position){
        Transform ItemTransform = Instantiate(ItemTem,Container);
        ItemTransform.gameObject.SetActive(true);
        RectTransform ItemRectTransform = ItemTransform.GetComponent<RectTransform>();
    
        ItemRectTransform.anchoredPosition = new Vector2(-10.71307f, position);

        ItemTransform.Find("NameTuition").GetComponent<Text>().text = Name;
        ItemTransform.Find("CostTuition").GetComponent<Text>().text = Cost.ToString();

        ItemTransform.Find("ImageTuition").GetComponent<Image>().sprite = Icon;
    }
}
