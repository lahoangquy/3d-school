using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class PlayerGetJob : MonoBehaviour
{
    public GameObject Item;

    public void AcceptJob()
    {
        if (!Item.activeSelf){
            Item.SetActive(true);
        }
    }
}
