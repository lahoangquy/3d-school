using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteJob : MonoBehaviour
{
    public GameObject Item;

    public void CheckForItem(){
        if (Item.activeSelf){
            Debug.Log("mission complete");
            Item.SetActive(false);
        }
    }
}
