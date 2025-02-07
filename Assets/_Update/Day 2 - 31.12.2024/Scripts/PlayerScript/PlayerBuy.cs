using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBuy : MonoBehaviour
{
    public GameObject Item;
    public void Buy()
    {
        if (!Item.activeSelf){
            Item.SetActive(true);
        }
    } 
}
