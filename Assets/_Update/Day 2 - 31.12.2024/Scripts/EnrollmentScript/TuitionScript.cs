using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
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

    public void CreateTuition(Sprite Icon,String Name,int Cost,int position){
        Transform ItemTransform = Instantiate(ItemTem,Container);
        RectTransform ItemRectTransform = ItemTransform.GetComponent<RectTransform>();

        float Itemheight = 133.6228f;
        ItemRectTransform.anchoredPosition = new Vector2(0, -Itemheight * position);

        ItemTransform.Find("NameTuition").GetComponent<Text>().text = Name;
        ItemTransform.Find("CostTuition").GetComponent<Text>().text = Cost.ToString();

        ItemTransform.Find("ImageTuition").GetComponent<Image>().sprite = Icon;
    }
}
