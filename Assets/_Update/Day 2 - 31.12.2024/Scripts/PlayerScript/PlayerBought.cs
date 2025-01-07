using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBought : MonoBehaviour
{
    public GameObject Item;
    public void Buy()
    {
        if (!Item.activeSelf){
            Item.SetActive(true);
        }
    } 
}
